using Microsoft.EntityFrameworkCore;

namespace SlangApiRest.Helpers
{
    public static class HttpContextExtensions
    {
        public static async Task InsertParameters<T>(this HttpContext context, IEnumerable<T> queryable, int quantityToShow) 
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            else { 
                double count = queryable.Count();
                var totalPages = Math.Ceiling(count / quantityToShow);
                context.Response.Headers.Add("totalPages", totalPages.ToString());
            }
        }
    }
}
