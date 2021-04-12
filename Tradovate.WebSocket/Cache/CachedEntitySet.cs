using System.Collections.Generic;
using System.Collections.Concurrent;
using Newtonsoft.Json.Linq;

namespace Tradovate.Services.Cache
{
    class CachedEntitySet
    {
        private ConcurrentDictionary<string, JObject> ByName = new ConcurrentDictionary<string, JObject>();
        private ConcurrentDictionary<long, JObject> ById = new ConcurrentDictionary<long, JObject>();
        private ConcurrentDictionary<long, ConcurrentDictionary<long, JObject>> ByMasterId = new ConcurrentDictionary<long, ConcurrentDictionary<long, JObject>>();
        private EntityCacheSpec EntityCacheSpec;

        public CachedEntitySet(EntityCacheSpec EntityCacheSpec)
        {
            this.EntityCacheSpec = EntityCacheSpec;
        }

        public bool LoadedAll = false;

        public bool TryFind(string name, out JObject entity)
        {
            return ByName.TryGetValue(name, out entity);
        }

        public bool TryGet(long id, out JObject entity)
        {
            return ById.TryGetValue(id, out entity);
        }

        public JArray GetList()
        {
            var list = new JArray();
            foreach (var entity in ById.Values)
            {
                list.Add(entity);
            }
            return list;
        }

        public JArray GetDeps(long masterId)
        {
            var result = new JArray();
            ConcurrentDictionary<long, JObject> collection;
            if (ByMasterId.TryGetValue(masterId, out collection))
            {
                foreach (var entity in collection.Values)
                {
                    result.Add(entity);
                }
            }
            return result;
        }

        public JArray GetLDeps(List<long> masterIds)
        {
            var result = new JArray();
            ConcurrentDictionary<long, JObject> collection;
            foreach (var masterId in masterIds)
            {
                if (ByMasterId.TryGetValue(masterId, out collection))
                {
                    foreach (var entity in collection.Values)
                    {
                        result.Add(entity);
                    }
                }
            }
            return result;
        }

        void UpdateMasterCollection(long id, JObject entity)
        {
            if (EntityCacheSpec.MasterField != null)
            {
                long masterId = entity.Value<long>(EntityCacheSpec.MasterField);
                ConcurrentDictionary<long, JObject> collection;
                if (EntityCacheSpec.IsPreloaded)
                {
                    collection = ByMasterId.GetOrAdd(masterId, new ConcurrentDictionary<long, JObject>());
                }
                else
                {
                    ByMasterId.TryGetValue(masterId, out collection);
                }
                if (collection != null)
                {
                    collection[id] = entity;
                }
            }
        }

        void DeleteFromMasterCollection(long id, JObject entity)
        {
            if (EntityCacheSpec.MasterField != null)
            {
                long masterId = entity.Value<long>(EntityCacheSpec.MasterField);
                ConcurrentDictionary<long, JObject> collection;
                if (ByMasterId.TryGetValue(masterId, out collection))
                {
                    collection.TryRemove(id, out entity);
                }
            }
        }

        public void Update(string eventType, JObject entity)
        {
            var id = entity.Value<long>("id");
            var name = entity["name"];
            switch (eventType)
            {
                case "Created":
                    ById[id] = entity;
                    if (name != null)
                    {
                        ByName[name.ToString()] = entity;
                    }
                    UpdateMasterCollection(id, entity);
                    break;
                case "Updated":
                    JObject oldEntity;
                    if (ById.TryGetValue(id, out oldEntity))
                    {
                        var oldName = oldEntity["name"];
                        if (oldName != null)
                        {
                            ByName.TryRemove(oldName.ToString(), out oldEntity);
                        }
                    }
                    ById[id] = entity;
                    if (name != null)
                    {
                        ByName[name.ToString()] = entity;
                    }
                    UpdateMasterCollection(id, entity);
                    break;
                case "Deleted":
                    ById.TryRemove(id, out oldEntity);
                    if (name != null)
                    {
                        ByName.TryRemove(name.ToString(), out oldEntity);
                    }
                    DeleteFromMasterCollection(id, entity);
                    break;
                default:
                    break;
            }
        }
    }
}