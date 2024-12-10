using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Queries.ListSale
{
    public class ListSalesQueryHandler(ISaleRepository saleRepository, IMapper mapper)
    : IRequestHandler<ListSalesQuery, IEnumerable<GetSaleResult>>
    {
        public async Task<IEnumerable<GetSaleResult>> Handle(ListSalesQuery query, CancellationToken cancellationToken)
        {
            var sales = await saleRepository.GetAsync(cancellationToken);
            return mapper.Map<GetSaleResult[]>(sales);
        }
    }
}
