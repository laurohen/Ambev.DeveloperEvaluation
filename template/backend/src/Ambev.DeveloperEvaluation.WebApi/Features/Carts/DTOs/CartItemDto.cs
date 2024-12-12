namespace Ambev.DeveloperEvaluation.WebApi.Features.Carts.DTOs
{
    /// <summary>
    /// DTO for representing a cart item.
    /// </summary>
    public class CartItemDto
    {
        /// <summary>
        /// The ID of the product.
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// The quantity of the product in the cart.
        /// </summary>
        public int Quantity { get; set; }
    }
}
