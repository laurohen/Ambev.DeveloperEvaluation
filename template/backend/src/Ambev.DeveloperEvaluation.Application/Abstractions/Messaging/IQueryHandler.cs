using Ambev.DeveloperEvaluation.Domain.Shared;
using MediatR;
//using OneOf.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Abstractions.Messaging
{
    //public interface IQuery<TResponse> : IRequest<Result<TResponse>>;
    public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>;
}
