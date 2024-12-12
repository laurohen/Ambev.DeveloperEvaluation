using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.DeleteCart
{
    public sealed record DeleteCartItemCommand(Guid UserId, Guid ProductId) : IRequest<bool>;
}
