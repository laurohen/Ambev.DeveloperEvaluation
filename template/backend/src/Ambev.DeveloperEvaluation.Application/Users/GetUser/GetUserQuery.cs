using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Users.GetUser
{
    /// <summary>
    ///     Command for retrieving a user by their ID
    /// </summary>
    public record GetUserQuery(Guid Id) : IRequest<GetUserResult>;
}
