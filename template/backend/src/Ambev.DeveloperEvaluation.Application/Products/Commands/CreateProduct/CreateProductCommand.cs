using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    /// <summary>
    /// Command for creating a new product.
    /// </summary>
    public record CreateProductCommand(
        string Title,
        decimal Price,
        string Description,
        string Category,
        string Image,
        ProductRatingDto Rating
    ) : IRequest<CreateProductResult>;


    /// <summary>
    /// Represents the rating information of a product.
    /// </summary>
    public sealed record ProductRatingDto(double Rate, int Count);
}
