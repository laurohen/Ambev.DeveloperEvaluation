using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Queries
{
    public sealed record GetSaleResult(
    Guid Id,
    string SaleNumber,
    decimal TotalAmount,
    bool IsCancelled,
    Guid? CustomerId,
    Guid? BranchId,
    DateTime CreatedAt,
    DateTime? UpdatedAt,
    IEnumerable<SaleItemDto> Items);
}
