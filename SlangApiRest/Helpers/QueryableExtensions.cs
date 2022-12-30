using SlangApiRest.ModelsDB;
using SlangModels;

namespace SlangApiRest.Helpers
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> MakePage<T>(this IQueryable<T> queryable, Pagination pagination) {

            var n = pagination.Page - 1;
            var m = n * pagination.Quantity;
            return queryable.Skip(m).Take(pagination.Quantity);
        }
    }
}
