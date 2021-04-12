namespace Tradovate.Services.Cache
{
    class EntityCacheSpec
    {
        public readonly bool IsPreloaded;
        public readonly string MasterField;
        public readonly bool CanLoadAll;

        public EntityCacheSpec(bool IsPreloaded, string MasterField, bool CanLoadAll)
        {
            this.IsPreloaded = IsPreloaded;
            this.MasterField = MasterField;
            this.CanLoadAll = CanLoadAll;
        }
    }
}