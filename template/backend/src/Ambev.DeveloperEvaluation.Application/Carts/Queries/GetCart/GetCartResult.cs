using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCart
{
    public sealed record GetCartResult(
    Guid Id,
    Guid UserId,
    DateTime CreatedAt,
    IEnumerable<CartItemDto> Products);
}
