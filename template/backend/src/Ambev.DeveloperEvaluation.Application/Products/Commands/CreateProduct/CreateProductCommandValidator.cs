using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(product => product.Title)
                .NotEmpty()
                .WithMessage("Title is required.")
                .MaximumLength(100)
                .WithMessage("Title must not exceed 100 characters.");

            RuleFor(product => product.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than zero.");

            RuleFor(product => product.Description)
                .NotEmpty()
                .WithMessage("Description is required.")
                .MaximumLength(500)
                .WithMessage("Description must not exceed 500 characters.");

            RuleFor(product => product.Category)
                .NotEmpty()
                .WithMessage("Category is required.");

            RuleFor(product => product.Image)
                .NotEmpty()
                .WithMessage("Image URL is required.");

            RuleFor(product => product.Rating)
                .NotNull()
                .WithMessage("Rating is required.")
                .SetValidator(new ProductRatingDtoValidator());
        }
    }

    public class ProductRatingDtoValidator : AbstractValidator<ProductRatingDto>
    {
        public ProductRatingDtoValidator()
        {
            RuleFor(rating => rating.Rate)
                .InclusiveBetween(0, 5)
                .WithMessage("Rate must be between 0 and 5.");

            RuleFor(rating => rating.Count)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Count must be zero or greater.");
        }
    }
}
