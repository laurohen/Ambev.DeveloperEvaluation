using Ambev.DeveloperEvaluation.MessageBroker.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker.Messages
{
    public interface ISaleDeleted : IResponse
    {
        public string SaleNumber { get; set; }
    }
}
