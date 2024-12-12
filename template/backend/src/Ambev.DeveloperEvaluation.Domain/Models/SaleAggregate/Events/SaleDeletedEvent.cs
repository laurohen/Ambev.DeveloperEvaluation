using Ambev.DeveloperEvaluation.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Events
{
    public record SaleDeletedEvent(string SaleNumber) : IDomainEvent;
}
