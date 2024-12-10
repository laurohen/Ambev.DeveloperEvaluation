using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCart
{
    public sealed record GetCartByUserQuery(Guid UserId) : IRequest<GetCartResult>;
}
