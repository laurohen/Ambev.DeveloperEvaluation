using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Queries.GetSale
{
    public sealed record GetSaleByIdQuery(Guid Id) : IRequest<GetSaleResult>;
}
