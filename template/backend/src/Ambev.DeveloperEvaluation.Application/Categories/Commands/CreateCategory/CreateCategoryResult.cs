using Ambev.DeveloperEvaluation.Application.Categories.DTOs;
using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.CreateCategory
{
    /// <summary>
    /// Response for the CreateCategory command.
    /// </summary>
    public class CreateCategoryResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<ValidationErrorDetail>? Errors { get; set; }
        public CategoryDto? Data { get; set; }
    }
}
