using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public sealed record CreateOrUpdateCartResult
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<CreateCartItemDto>? Products { get; set; }
    }
}
