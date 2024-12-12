using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Validator for CreateProductRequest.
    /// </summary>
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(product => product.Title)
                .NotEmpty()
                .NotNull()
                .Length(3, 50)
                .WithMessage("Title must be between 3 and 50 characters long and cannot be empty.");

            RuleFor(product => product.Price)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("Price must be greater than 0.");

            RuleFor(product => product.Description)
                .NotEmpty()
                .NotNull()
                .Length(5, 500)
                .WithMessage("Description must be between 5 and 500 characters long.");

            RuleFor(product => product.Category)
                .NotEmpty()
                .NotNull()
                .WithMessage("Category cannot be empty.");

            RuleFor(product => product.Image)
                .NotEmpty()
                .NotNull()
                .WithMessage("Image URL cannot be empty.");

            RuleFor(product => product.Rating)
                .NotNull()
                .WithMessage("Rating details must be provided.")
                .SetValidator(new ProductRatingRequestValidator());
        }
    }

    /// <summary>
    /// Validator for ProductRatingRequest.
    /// </summary>
    public class ProductRatingRequestValidator : AbstractValidator<ProductRatingRequest>
    {
        public ProductRatingRequestValidator()
        {
            RuleFor(rating => rating.Rate)
                .InclusiveBetween(0, 5)
                .WithMessage("Rate must be between 0 and 5.");

            RuleFor(rating => rating.Count)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Count must be greater than or equal to 0.");
        }
    }
}
