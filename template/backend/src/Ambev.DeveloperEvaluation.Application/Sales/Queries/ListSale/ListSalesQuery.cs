using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Queries.ListSale
{
    public sealed record ListSalesQuery : IRequest<IEnumerable<GetSaleResult>>;
}
