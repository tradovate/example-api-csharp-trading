using System.Collections.Generic;

namespace Tradovate.Services.Cache
{
    class EntityCacheSpecs
    {
        private Dictionary<string, EntityCacheSpec> Specs = new Dictionary<string, EntityCacheSpec>();

        public EntityCacheSpecs()
        {
            Specs["command"] = new EntityCacheSpec(true, "orderId", true);
            Specs["commandReport"] = new EntityCacheSpec(true, "commandId", true);
            Specs["executionReport"] = new EntityCacheSpec(true, "commandId", true);
            Specs["fill"] = new EntityCacheSpec(true, "orderId", true);
            Specs["orderVersion"] = new EntityCacheSpec(true, "orderId", true);

            Specs["tradingPermission"] = new EntityCacheSpec(false, "userId", true);

            Specs["contract"] = new EntityCacheSpec(false, "contractMaturityId", false);
            Specs["contractGroup"] = new EntityCacheSpec(false, null, true);
            Specs["contractMaturity"] = new EntityCacheSpec(false, "productId", false);
            Specs["currency"] = new EntityCacheSpec(false, null, true);
            Specs["currencyRate"] = new EntityCacheSpec(false, "id", true);
            Specs["exchange"] = new EntityCacheSpec(false, null, true);
            Specs["product"] = new EntityCacheSpec(false, null, true);
            Specs["productMargin"] = new EntityCacheSpec(false, "id", true);
        }

        public EntityCacheSpec this[string entityType]
        {
            get
            {
                EntityCacheSpec result;
                if (Specs.TryGetValue(entityType, out result))
                {
                    return result;
                }
                return new EntityCacheSpec(false, null, false);
            }
        }
    }
}