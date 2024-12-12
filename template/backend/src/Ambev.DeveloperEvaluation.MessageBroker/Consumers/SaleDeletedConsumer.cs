using Ambev.DeveloperEvaluation.MessageBroker.Messages;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.MessageBroker.Consumers
{
    public class SaleDeletedConsumer : IConsumer<ISaleDeleted>
    {
        public async Task Consume(ConsumeContext<ISaleDeleted> context)
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
