using Ambev.DeveloperEvaluation.Common.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    /// <summary>
    /// Represents the result of the CreateProductCommand.
    /// </summary>
    public class CreateProductResult
    {
        /// <summary>
        /// Indicates whether the operation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides a message describing the result of the operation.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Contains validation error details if the operation failed.
        /// </summary>
        public List<ValidationErrorDetail>? Errors { get; set; }

        /// <summary>
        /// The unique identifier of the product, returned only on success.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The title of the product, returned only on success.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The price of the product, returned only on success.
        /// </summary>
        public decimal? Price { get; set; }

        /// <summary>
        /// The description of the product, returned only on success.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The category of the product, returned only on success.
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// The image URL of the product, returned only on success.
        /// </summary>
        public string? Image { get; set; }

        /// <summary>
        /// The rating details of the product, returned only on success.
        /// </summary>
        public ProductRatingDto? Rating { get; set; }
    }

}
