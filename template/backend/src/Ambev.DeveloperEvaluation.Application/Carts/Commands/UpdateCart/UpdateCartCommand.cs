using Ambev.DeveloperEvaluation.Domain.Models.UserAggregate.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.UpdateCart
{
    //public record UpdateCartCommand(
    //Guid Id,
    //Guid UserId,
    //DateTime Date,
    //List<UpdateCartProductDto> Products
    //) : IRequest;

    //public record UpdateCartProductDto(
    //    Guid ProductId,
    //    int Quantity
    //);

    /// <summary>
    /// Command for updating a cart.
    /// </summary>
    //public record UpdateCartCommand : IRequest<UpdateCartResult?>
    //{
    //    /// <summary>
    //    /// The ID of the cart to be updated.
    //    /// </summary>
    //    public Guid Id { get; set; }

    //    /// <summary>
    //    /// The User of the cart to be updated.
    //    /// </summary>
    //    public Guid UserId { get; set; }

    //    /// <summary>
    //    /// The updated list of items in the cart.
    //    /// </summary>
    //    public List<CartItemCommand> Products { get; set; } = new();
    //}

    /// <summary>
    /// Command for updating a cart.
    /// </summary>
    public record UpdateCartCommand(Guid Id, Guid UserId, List<UpdateCartProductDto> Products) : IRequest<UpdateCartResult?>;

}
