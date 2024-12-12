using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.UpdateSale
{
    public sealed record UpdateSaleCommand(
    Guid Id,
    string SaleNumber,
    decimal TotalAmount,
    bool IsCancelled,
    Guid? CustomerId,
    Guid? BranchId,
    IEnumerable<SaleItemDto> Items
) : IRequest<UpdateSaleResult>
    {
        public UpdateSaleCommand() : this(default, string.Empty, 0, false, null, null, [])
        {
        }
    }
}
