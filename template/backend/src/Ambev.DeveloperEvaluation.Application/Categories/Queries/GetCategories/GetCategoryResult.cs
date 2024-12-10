using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.GetCategories
{
    /// <summary>
    /// Response for retrieving a single category.
    /// </summary>
    public class GetCategoryResult
    {
        /// <summary>
        /// The unique identifier of the category.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A brief description of the category.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
