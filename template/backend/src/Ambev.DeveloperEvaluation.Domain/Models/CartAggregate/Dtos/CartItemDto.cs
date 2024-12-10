using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Dtos
{
    public sealed record CartItemDto(Guid Id, Guid ProductId, int Quantity)
    {
        public CartItemDto() : this(default, default, default)
        {
        }
    }
}
