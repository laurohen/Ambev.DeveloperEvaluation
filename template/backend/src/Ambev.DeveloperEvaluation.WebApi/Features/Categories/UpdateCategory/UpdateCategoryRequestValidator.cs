using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.UpdateCategory
{
    /// <summary>
    /// Validator for UpdateCategoryRequest.
    /// </summary>
    public class UpdateCategoryRequestValidator : AbstractValidator<UpdateCategoryRequest>
    {
        public UpdateCategoryRequestValidator()
        {
            RuleFor(request => request.Name)
                .NotEmpty()
                .WithMessage("The category name is required.")
                .MaximumLength(100)
                .WithMessage("The category name must be at most 100 characters.");

            RuleFor(request => request.Description)
                .MaximumLength(500)
                .WithMessage("The category description must be at most 500 characters.");
        }
    }
}
