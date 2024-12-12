using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.UpdateCart
{
    /// <summary>
    /// Represents a product to update in the cart.
    /// </summary>
    //public class UpdateCartProductDto
    //{
    //    /// <summary>
    //    /// The unique identifier of the product.
    //    /// </summary>
    //    public Guid ProductId { get; set; }

    //    /// <summary>
    //    /// The quantity of the product in the cart.
    //    /// </summary>
    //    public int Quantity { get; set; }
    //}

    /// <summary>
    /// Data transfer object representing a product in the cart.
    /// </summary>
    public record UpdateCartProductDto(Guid ProductId, int Quantity);
}
