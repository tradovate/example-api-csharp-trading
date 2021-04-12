using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;
using Newtonsoft.Json.Linq;

namespace Tradovate.Services.Cache
{
    class SessionCache : ICache
    {
        private ConcurrentDictionary<string, CachedEntitySet> CachedEntities = new ConcurrentDictionary<string, CachedEntitySet>();
        private EntityCacheSpecs EntityCacheSpecs = new EntityCacheSpecs();

        public SessionCache(JObject initialDataSet)
        {
            foreach (var entityCollection in initialDataSet)
            {
                var entityType = CovertToEntityType(entityCollection.Key);
                ConsumeCollection(entityType, entityCollection.Value as JArray, EntityCacheSpecs[entityType].IsPreloaded);
            }
        }

        string CovertToEntityType(string entitiesCollectionName)
        {
            // users -> user, contractMaturities -> contractMaturity
            var entityType = entitiesCollectionName;
            if (entityType.EndsWith("ses"))
            {
                entityType = entityType.Substring(0, entitiesCollectionName.Length - 2);
            }
            else if (entityType.EndsWith("s"))
            {
                entityType = entityType.Substring(0, entitiesCollectionName.Length - 1);
                if (entityType.EndsWith("ie"))
                {
                    entityType = entityType.Substring(0, entityType.Length - 2) + "y";
                }
            }
            return entityType;
        }

        public void Update(string eventType, string entityType, JObject entity)
        {
            CachedEntitySet cachedEntitySet = CachedEntities.GetOrAdd(entityType, new CachedEntitySet(EntityCacheSpecs[entityType]));
            cachedEntitySet.Update(eventType, entity);
        }

        public void ConsumeResponse(string endpoint, JToken response)
        {
            var path = endpoint.Split('/');
            if (path.Length == 2)
            {
                var entityType = path[0];
                var method = path[1];
                if (method == "find" || method == "item")
                {
                    var entity = response as JObject;
                    CachedEntitySet cachedEntitySet = CachedEntities.GetOrAdd(entityType, new CachedEntitySet(EntityCacheSpecs[entityType]));
                    cachedEntitySet.Update("Updated", entity);
                }
                else if (method == "list" || method == "deps" || method == "ldeps" || method == "suggest" || method == "items")
                {
                    ConsumeCollection(entityType, response as JArray, method == "list" && EntityCacheSpecs[entityType].CanLoadAll);
                }
            }
        }

        public bool TryRespond(string endpoint, string queryParameters, out JToken response)
        {
            var path = endpoint.Split('/');
            if (path.Length == 2)
            {
                var entityType = path[0];
                var method = path[1];
                var entityCacheSpec = EntityCacheSpecs[entityType];
                CachedEntitySet cachedEntitySet;
                if (CachedEntities.TryGetValue(entityType, out cachedEntitySet))
                {
                    switch (method)
                    {
                        case "find":
                            if (queryParameters.StartsWith("name="))
                            {
                                var name = queryParameters.Substring(5);
                                JObject entity;
                                if (cachedEntitySet.TryFind(name, out entity))
                                {
                                    response = entity;
                                    return true;
                                }
                            }
                            break;
                        case "item":
                            if (queryParameters.StartsWith("id="))
                            {
                                long id;
                                if (long.TryParse(queryParameters.Substring(3), out id))
                                {
                                    JObject entity;
                                    if (cachedEntitySet.TryGet(id, out entity))
                                    {
                                        response = entity;
                                        return true;
                                    }
                                }
                            }
                            break;
                        case "list":
                            if (entityCacheSpec.IsPreloaded || entityCacheSpec.CanLoadAll && cachedEntitySet.LoadedAll)
                            {
                                response = cachedEntitySet.GetList();
                                return true;
                            }
                            break;
                        case "deps":
                            if (entityCacheSpec.IsPreloaded || entityCacheSpec.CanLoadAll && cachedEntitySet.LoadedAll)
                            {
                                if (queryParameters.StartsWith("masterid="))
                                {
                                    int masterId;
                                    if (int.TryParse(queryParameters.Substring(9), out masterId))
                                    {
                                        response = cachedEntitySet.GetDeps(masterId);
                                        return true;
                                    }
                                }
                            }
                            break;
                        case "ldeps":
                            if (entityCacheSpec.IsPreloaded || entityCacheSpec.CanLoadAll && cachedEntitySet.LoadedAll)
                            {
                                if (queryParameters.StartsWith("masterids="))
                                {
                                    var masterIds = queryParameters.Substring(10).Split(',').Select(strId => long.Parse(strId)).ToList();
                                    response = cachedEntitySet.GetLDeps(masterIds);
                                    return true;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    switch (method)
                    {
                        case "list":
                        case "deps":
                        case "ldeps":
                            if (entityCacheSpec.IsPreloaded)
                            {
                                response = new JArray();
                                return true;
                            }
                            break;
                    }
                }
            }
            response = null;
            return false;
        }

        void ConsumeCollection(string entityType, JArray collection, bool loadedAll)
        {
            CachedEntitySet cachedEntitySet = CachedEntities.GetOrAdd(entityType, new CachedEntitySet(EntityCacheSpecs[entityType]));
            cachedEntitySet.LoadedAll = cachedEntitySet.LoadedAll || loadedAll;
            foreach (var entity in collection)
            {
                cachedEntitySet.Update("Updated", entity as JObject);
            }
        }
    }
}