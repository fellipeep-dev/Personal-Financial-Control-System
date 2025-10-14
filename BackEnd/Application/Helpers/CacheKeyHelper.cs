using Domain.Entities;

namespace Application.Helpers
{
    public static class CacheKeyHelper
    {
        public static string GetListKey<TEntity>() where TEntity : Entity
        {
            return $"{typeof(TEntity).Name}_List";
        }

        public static string GetItemKey<TEntity>(Guid id) where TEntity : Entity
        {
            return $"{typeof(TEntity).Name}_{id}";
        }
    }
}
