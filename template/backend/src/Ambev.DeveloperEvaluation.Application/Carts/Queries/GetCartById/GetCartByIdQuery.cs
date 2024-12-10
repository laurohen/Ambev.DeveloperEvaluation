using Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCartById
{
    public record GetCartByIdQuery : IRequest<GetCartByIdResponse>
    {
        public Guid Id { get; set; }
    }

    public record GetCartByIdResponse(Guid Id, Guid UserId, DateTime CreatedAt, List<CreateCartItemDto> Products);
}
