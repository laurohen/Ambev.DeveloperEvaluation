using Ambev.DeveloperEvaluation.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.DeleteCategory
{
    /// <summary>
    /// Response for the DeleteCategory command.
    /// </summary>
    public class DeleteCategoryResult
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<ValidationErrorDetail>? Errors { get; set; }
    }
}
