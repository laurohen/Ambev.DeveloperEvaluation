using Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdateProductResult>
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public Guid Category { get; set; } //= string.Empty;
        public string Image { get; set; } = string.Empty;
        public ProductRatingDto Rating { get; set; } = new ProductRatingDto(0, 0);
    }

    public record UpdateProductResult(
        int Id,
        string Title,
        decimal Price,
        string Description,
        string Category,
        string Image,
        ProductRatingDto Rating
    );
}
