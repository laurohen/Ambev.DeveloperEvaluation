using Ambev.DeveloperEvaluation.MessageBroker.Messages;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker.Consumers
{
    public class SaleUpdatedConsumer : IConsumer<ISaleUpdated>
    {
        public async Task Consume(ConsumeContext<ISaleUpdated> context)
        {
            try
            {
                Console.WriteLine("Message received at consumer");
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
