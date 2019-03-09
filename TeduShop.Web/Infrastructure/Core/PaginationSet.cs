using System.Collections.Generic;
using System.Linq;

namespace TeduShop.Web.Infrastructure.Core
{
    /// <summary>
    /// PaginationSet
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PaginationSet<T>
    {
        /// <summary>
        /// Count
        /// </summary>
        public int Count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }
        /// <summary>
        /// Page
        /// </summary>
        public int Page { set; get; }
        /// <summary>
        /// TotalPages
        /// </summary>
        public int TotalPages { set; get; }
        /// <summary>
        /// TotalCount
        /// </summary>
        public int TotalCount { set; get; }
        /// <summary>
        /// Items
        /// </summary>
        public IEnumerable<T> Items { set; get; }
    }
}