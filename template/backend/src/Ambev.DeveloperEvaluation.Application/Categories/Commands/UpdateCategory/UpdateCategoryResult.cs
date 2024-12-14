using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.UpdateCategory
{
    /// <summary>
    /// Response for the UpdateCategory command.
    /// </summary>
    public class UpdateCategoryResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<ValidationErrorDetail>? Errors { get; set; }
    }
}
