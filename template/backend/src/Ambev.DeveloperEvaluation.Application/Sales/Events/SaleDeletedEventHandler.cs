﻿using Ambev.DeveloperEvaluation.Application.Abstractions.Messaging;
using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Events;
using Ambev.DeveloperEvaluation.MessageBroker.Common;
using Ambev.DeveloperEvaluation.MessageBroker.Messages;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class SaleDeletedEventHandler(IPublishEndpoint publishEndpoint) : IDomainEventHandler<SaleDeletedEvent>
    {
        public async Task Handle(SaleDeletedEvent notification, CancellationToken cancellationToken)
        {
            try
            {
                await publishEndpoint.Publish<ISaleDeleted>(new
                {
                    Success = true,
                    notification.SaleNumber
                }, cancellationToken);
            }
            catch (Exception ex)
            {
                await publishEndpoint.Publish<IResponse>(new
                {
                    Success = false,
                    Message = $"{ex.Message}-{ex.InnerException?.Message}"
                }, cancellationToken);
                throw;
            }
        }
    }
}