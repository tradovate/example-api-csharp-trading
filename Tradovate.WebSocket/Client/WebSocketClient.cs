/*
 *
 * Tradovate API, Websocket implementation
 *
*/

using System;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Security.Authentication;
using System.Collections.Generic;
using RestSharp;
using WebSocket4Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Tradovate.Services.Cache;

namespace Tradovate.Services.Client
{
    public class DataUpdate
    {
        public readonly string ModificationType;
        public readonly string EntityType;
        public readonly object Entity;
        public DataUpdate(string modificationType, string entityType, object entity)
        {
            this.ModificationType = modificationType;
            this.EntityType = entityType;
            this.Entity = entity;
        }

        public override string ToString()
        {
            return $"DataUpdate: {ModificationType}, {Entity}";
        }
    }

    public class IncomingMessage
    {
        public string e;
        public int i;
        public int s;
        public object d;
    }

    struct PendingRequest
    {
        public TaskCompletionSource<IRestResponse> Promise;
        public string RequestEndpoint;
    }

    class TaskQueue
    {
        private Task LastTask = Task.Run(() => { });
        public void Enqueue(Action action)
        {
            LastTask = LastTask.ContinueWith(previous => action());
        }
    }

    public partial class WebSocketClient : RestClient
    {
        private int RequestCounter = 0;
        private WebSocket WebSocket;
        private string AccessToken;
        private ConcurrentDictionary<int, PendingRequest> PendingRequests = new ConcurrentDictionary<int, PendingRequest>();
        private ICache Cache = new NoCache();
        private TaskQueue NotificationTaskQueue = new TaskQueue();

        public event EventHandler Opened;
        public event EventHandler Authorized;
        public event EventHandler Closed;
        public event EventHandler<DataUpdate> DataUpdated;

        public WebSocketClient(string uri, SslProtocols sslProtocols = SslProtocols.Tls12)
        {
            uri = uri.Replace("https:", "wss:") + "/websocket";
            WebSocket = new WebSocket(uri, sslProtocols: sslProtocols);
            WebSocket.EnableAutoSendPing = false;
            WebSocket.NoDelay = true;
            WebSocket.MessageReceived += WebSocket_MessageReceived;
            WebSocket.Closed += WebSocket_Closed;
            WebSocket.Error += WebSocket_Error;
            WebSocket.Open();
            ScheduleHeartbeats();
        }

        public void Close()
        {
            WebSocket.Close();
        }

        public void Dispose()
        {
            WebSocket.Dispose();
        }

        public override IRestResponse Execute(IRestRequest request)
        {
            JToken cachedResponse;
            if (Cache.TryRespond(GetEndpoint(request), GetQueryParameters(request), out cachedResponse))
            {
                return CreateRestResponse(200, cachedResponse);
            }
            else
            {
                var task = ExecuteTaskAsync(request);
                task.Wait(request.Timeout - 1);
                return task.Result;
            }
        }

        public override Task<IRestResponse> ExecuteTaskAsync(IRestRequest request)
        {
            Task<IRestResponse> authorizeTask = null;
            if (AccessToken == null)
            {
                var authorizationHeader = request.Parameters.FirstOrDefault(x => x.Type == ParameterType.HttpHeader && x.Name == "Authorization");
                if (authorizationHeader != null)
                {
                    AccessToken = authorizationHeader.Value.ToString().Replace("Bearer ", "");
                    authorizeTask = DoExecuteTaskAsync("authorize", "", AccessToken);
                }
            }
            if (authorizeTask != null)
            {
                return authorizeTask.ContinueWith<IRestResponse>(authorizeResponse =>
                {
                    if (authorizeResponse.Result.ResponseStatus == ResponseStatus.Completed)
                    {
                        Authorized?.Invoke(this, EventArgs.Empty);
                        var call = DoExecuteTaskAsync(request);
                        call.Wait(request.Timeout - 1);
                        return call.Result;
                    }
                    else
                    {
                        return authorizeResponse.Result;
                    }
                });
            }
            else
            {
                return DoExecuteTaskAsync(request);
            }
        }

        private async void ScheduleHeartbeats()
        {
            await Task.Delay(2500);
            if (WebSocket.State == WebSocketState.Open)
            {
                Log.Write("HEARTBEAT: SEND");
                WebSocket.Send("[]");
                ScheduleHeartbeats();
            }
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            Log.Write($"ERROR: {e.Exception}");
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
            Cache = new NoCache();
            var all = PendingRequests.Values.ToArray();
            PendingRequests.Clear();
            foreach (var pendingRequest in all)
            {
                pendingRequest.Promise.TrySetCanceled();
            }
            Closed?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void HandleEvent(IncomingMessage message)
        {
            switch (message.e)
            {
                case "shutdown":
                    Console.WriteLine($"Server is going to close this connection: {message.d}");
                    break;
                case "props":
                    string eventType = "", entityType = "";
                    List<JObject> entities = null;
                    foreach (var prop in (message.d as JContainer).Values<JProperty>())
                    {
                        switch (prop.Name)
                        {
                            case "eventType":
                                eventType = prop.Value.ToString();
                                break;
                            case "entityType":
                                entityType = prop.Value.ToString();
                                break;
                            case "entity":
                                if (prop.Value is JArray)
                                {
                                    entities = (prop.Value as JArray).Select(x => x as JObject).ToList();
                                }
                                else
                                {
                                    entities = new List<JObject> { prop.Value as JObject };
                                }
                                break;
                            default:
                                Log.Write($"Unrecognized event property: {prop}");
                                break;
                        }
                    }
                    NotificationTaskQueue.Enqueue(() =>
                    {
                        if (entities != null)
                        {
                            Console.Error.WriteLine($"EVENT: {eventType}, {entityType}, ${entities}");
                            foreach (var entity in entities)
                            {
                                Cache.Update(eventType, entityType, entity);
                            }
                            var typeName = entityType[0].ToString().ToUpper() + entityType.Substring(1);
                            typeName = $"Tradovate.Services.Model.{typeName}";
                            foreach (var entity in entities)
                            {
                                try
                                {
                                    var type = ResolveType(typeName);
                                    var entityObject = JsonConvert.DeserializeObject(entity.ToString(), type);
                                    DataUpdated?.Invoke(this, new DataUpdate(eventType, entityType, entityObject));
                                }
                                catch (Exception ex)
                                {
                                    Console.Error.WriteLine($"Cannot deserialize event's entity: {entityType}, {entity}, {ex}");
                                }
                            }
                        }
                        else
                        {
                            DataUpdated?.Invoke(this, new DataUpdate(eventType, entityType, null));
                        }
                    });
                    break;
            }
        }

        private Type ResolveType(string typeName)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                var type = a.GetType(typeName, false);
                if (type != null)
                {
                    return type;
                }
            }
            throw new TypeLoadException($"Cannot load '{typeName}'.");
        }

        private void HandleResponse(IncomingMessage message)
        {
            PendingRequest pendingRequest;
            if (PendingRequests.TryRemove(message.i, out pendingRequest))
            {
                var jsonResponse = message.d as JToken;
                var response = CreateRestResponse(message.s, jsonResponse);
                if (pendingRequest.RequestEndpoint == "user/syncrequest")
                {
                    Cache = new SessionCache(jsonResponse as JObject);
                }
                else if (jsonResponse != null)
                {
                    Cache.ConsumeResponse(pendingRequest.RequestEndpoint, jsonResponse);
                }
                pendingRequest.Promise.TrySetResult(response);
            }
        }

        private void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var frame = e.Message;
            Log.Write($"RECVD: {frame.Substring(0, Math.Min(50, frame.Length))}...");
            if (frame == "o")
            {
                Opened?.Invoke(this, EventArgs.Empty);
            }
            else if (frame == "h")
            {
                // Hearbeat
            }
            else if (frame == "c")
            {
                WebSocket.Close();
            }
            else if (frame[0] == 'a')
            {
                var json = frame.Substring(1);
                var messages = JsonConvert.DeserializeObject<IncomingMessage[]>(json);
                foreach (var message in messages)
                {
                    if (message.e != null)
                    {
                        HandleEvent(message);
                    }
                    else
                    {
                        HandleResponse(message);
                    }
                }
            }
        }

        private IRestResponse CreateRestResponse(int statusCode, JToken content)
        {
            var response = new RestResponse();
            response.StatusCode = (System.Net.HttpStatusCode)statusCode;
            response.Content = content?.ToString();
            if (response.Content != null)
            {
                response.ContentLength = response.Content.Length;
            }
            if (statusCode / 100 == 2)
            {
                response.ResponseStatus = ResponseStatus.Completed;
            }
            else
            {
                response.ResponseStatus = ResponseStatus.Error;
            }
            return response;
        }

        private Task<IRestResponse> DoExecuteTaskAsync(string endpoint, string queryParams, string body)
        {
            var promise = new TaskCompletionSource<IRestResponse>();
            JToken cachedResponse;
            if (Cache.TryRespond(endpoint, queryParams, out cachedResponse))
            {
                // Log.Write($"FROM CACHE: {cachedResponse.ToString().Replace("\n", "").Replace("\r", "")}");
                promise.TrySetResult(CreateRestResponse(200, cachedResponse));
            }
            else
            {
                var id = Interlocked.Increment(ref RequestCounter);
                var frame = $"{endpoint}\n{id}\n{queryParams}\n{body}";
                PendingRequests.TryAdd(id, new PendingRequest { Promise = promise, RequestEndpoint = endpoint });
                WebSocket.Send(frame);
                Log.Write($"SENT: {frame.Replace("\n", "\\n")}");
            }
            return promise.Task;
        }

        private string GetQueryParameters(IRestRequest request)
        {
            var queryParameters = request.Parameters.Where(x => x.Type == ParameterType.QueryString).Select(x => x.Name + "=" + x.Value.ToString());
            return string.Join("&", queryParameters);
        }

        private string GetBodyParameter(IRestRequest request)
        {
            var bodyParameter = request.Parameters.FirstOrDefault(x => x.Type == ParameterType.RequestBody);
            if (bodyParameter != null)
            {
                return bodyParameter.Value.ToString();
            }
            return "";
        }

        private string GetEndpoint(IRestRequest request)
        {
            return request.Resource.Substring(1);
        }

        private Task<IRestResponse> DoExecuteTaskAsync(IRestRequest request)
        {
            return DoExecuteTaskAsync(GetEndpoint(request), GetQueryParameters(request), GetBodyParameter(request));
        }
    }
}