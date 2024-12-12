using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Categories.ListCategories
{
    /// <summary>
    /// Validator for the ListCategoriesRequest.
    /// </summary>
    public class ListCategoriesRequestValidator : AbstractValidator<ListCategoriesRequest>
    {
        /// <summary>
        /// Initializes a new instance of ListCategoriesRequestValidator.
        /// </summary>
        public ListCategoriesRequestValidator()
        {
            // Page must be greater than or equal to 1
            RuleFor(request => request.Page)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Page must be greater than or equal to 1.");

            // Size must be greater than or equal to 1 and less than or equal to 100
            RuleFor(request => request.Size)
                .GreaterThanOrEqualTo(1)
                .WithMessage("Size must be greater than or equal to 1.")
                .LessThanOrEqualTo(100)
                .WithMessage("Size must be less than or equal to 100.");

            // Order is optional but must not be empty or null if provided
            RuleFor(request => request.Order)
                .NotEmpty()
                .When(request => !string.IsNullOrEmpty(request.Order))
                .WithMessage("Order must not be empty if provided.");
        }
    }
}
