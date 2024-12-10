using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public sealed record AddOrUpdateCartItemCommand(Guid UserId, Guid ProductId, int Quantity
) : IRequest<CreateOrUpdateCartResult>
    {
        public AddOrUpdateCartItemCommand() : this(Guid.Empty, Guid.Empty, default) { }
    }
}
