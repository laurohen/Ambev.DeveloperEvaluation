using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker
{
    public class QueueSettings
    {
        public required string Address { get; init; }
        public required int Port { get; init; }
        public required string VirtualHost { get; init; }
        public required string Username { get; init; }
        public required string Password { get; init; }
        public required int RetryCount { get; init; }
        public required int RetryInterval { get; init; }
    }
}
