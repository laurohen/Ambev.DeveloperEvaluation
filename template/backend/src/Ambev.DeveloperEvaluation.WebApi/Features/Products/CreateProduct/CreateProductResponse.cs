using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    /// <summary>
    /// Represents the response for creating a new product.
    /// </summary>
    public sealed record CreateProductResponse
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
        public Guid Id { get; set; }
        public string Title { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public string Description { get; init; } = string.Empty;
        public string Category { get; init; } = string.Empty;
        public string Image { get; init; } = string.Empty;
        public ProductRatingResponse Rating { get; init; } = new ProductRatingResponse();
    }

    /// <summary>
    /// Represents the rating details of a product in the response.
    /// </summary>
    public sealed record ProductRatingResponse
    {
        public double Rate { get; init; }
        public int Count { get; init; }
    }
}
