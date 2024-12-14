using Ambev.DeveloperEvaluation.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Branches.Commands.Delete_Branch
{
    public class DeleteBranchResult
    {
        /// <summary>
        /// Indicates whether the deletion was successful
        /// </summary>
        public bool Success { get; set; }

        public string Message { get; set; } = string.Empty;
        public List<ValidationErrorDetail>? Errors { get; set; }
    }
}
