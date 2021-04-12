using Newtonsoft.Json.Linq;

namespace Tradovate.Services.Cache
{
    interface ICache
    {
        void Update(string eventType, string entityType, JObject entity);
        void ConsumeResponse(string endpoint, JToken response);
        bool TryRespond(string endpoint, string queryParameters, out JToken response);
    }
}