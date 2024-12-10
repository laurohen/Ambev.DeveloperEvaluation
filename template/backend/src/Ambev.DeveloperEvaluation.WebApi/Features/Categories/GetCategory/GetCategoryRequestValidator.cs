using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.GetCategory
{
    /// <summary>
    /// Validator for GetCategoryRequest.
    /// </summary>
    public class GetCategoryRequestValidator : AbstractValidator<GetCategoryRequest>
    {
        public GetCategoryRequestValidator()
        {
            RuleFor(request => request.Id)
                .NotEmpty()
                .WithMessage("The category ID is required.");
        }
    }
}
