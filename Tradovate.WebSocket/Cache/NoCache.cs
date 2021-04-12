using Newtonsoft.Json.Linq;

namespace Tradovate.Services.Cache
{
    class NoCache : ICache
    {
        public void Update(string eventType, string entityType, JObject entity)
        {
        }

        public void ConsumeResponse(string endpoint, JToken response)
        {

        }

        public bool TryRespond(string endpoint, string queryParameters, out JToken response)
        {
            response = null;
            return false;
        }
    }
}