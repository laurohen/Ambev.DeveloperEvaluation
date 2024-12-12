using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.DeleteCategory
{
    /// <summary>
    /// Validator for DeleteCategoryRequest.
    /// </summary>
    public class DeleteCategoryRequestValidator : AbstractValidator<DeleteCategoryRequest>
    {
        public DeleteCategoryRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty()
                .WithMessage("Category ID is required.");
        }
    }
}
