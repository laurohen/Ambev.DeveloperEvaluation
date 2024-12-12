using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public record CreateCartCommand(Guid UserId, List<CreateCartItemDto> Products) : IRequest<CreateCartResult>;

    public record CreateCartItemDto(Guid ProductId, int Quantity);

    public record CreateCartResponse(Guid Id, Guid UserId, DateTime CreatedAt, List<CreateCartItemDto> Products);
}
