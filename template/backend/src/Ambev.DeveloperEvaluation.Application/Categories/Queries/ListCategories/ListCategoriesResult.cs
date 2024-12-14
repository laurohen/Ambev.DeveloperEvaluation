using Ambev.DeveloperEvaluation.Application.Categories.DTOs;
using Ambev.DeveloperEvaluation.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Queries.ListCategories
{
    /// <summary>
    /// Response for listing categories with pagination.
    /// </summary>
    public class ListCategoriesResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<ValidationErrorDetail>? Errors { get; set; }
        public List<CategoryDto>? Categories { get; set; }
        public int TotalCount { get; set; }
    }
}
