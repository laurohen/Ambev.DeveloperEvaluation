using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Categories.Commands.UpdateCategory
{
    /// <summary>
    /// Validator for UpdateCategoryCommand.
    /// </summary>
    public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator()
        {
            // Ensure the category ID is not empty
            RuleFor(command => command.Id)
                .NotEmpty()
                .WithMessage("Category ID is required.");

            // Ensure the category name is not empty and has a reasonable length
            RuleFor(command => command.Name)
                .NotEmpty()
                .WithMessage("Category name is required.")
                .MaximumLength(100)
                .WithMessage("Category name cannot exceed 100 characters.");

            // Ensure the category description has a reasonable length
            RuleFor(command => command.Description)
                .MaximumLength(500)
                .WithMessage("Category description cannot exceed 500 characters.");
        }
    }
}
