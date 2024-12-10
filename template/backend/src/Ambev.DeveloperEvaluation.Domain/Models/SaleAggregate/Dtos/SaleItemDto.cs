using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Dtos
{
    public sealed record SaleItemDto(
    Guid Id,
    int Quantity,
    decimal UnitPrice,
    decimal Discount,
    decimal TotalItemAmount,
    Guid ProductId)
    {
        public SaleItemDto() : this(Guid.Empty, 0, 0, 0, 0, Guid.Empty)
        {
        }
    }
}
