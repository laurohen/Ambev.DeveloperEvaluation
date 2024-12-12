using Ambev.DeveloperEvaluation.Domain.Common;
using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Events
{
    public record SaleCreatedEvent(Sale Sale) : IDomainEvent;
}
