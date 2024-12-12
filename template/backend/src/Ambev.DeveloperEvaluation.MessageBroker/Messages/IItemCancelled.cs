using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Dtos;
using Ambev.DeveloperEvaluation.MessageBroker.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker.Messages
{
    public interface IItemCancelled : IResponse
    {
        public SaleItemDto Item { get; set; }
    }
}
