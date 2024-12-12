using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCarts
{
    public record GetCartsQuery : IRequest<List<GetCartResponse>>;

    public record GetCartResponse(Guid Id, Guid UserId, DateTime CreatedAt);
}
