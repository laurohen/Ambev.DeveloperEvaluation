﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.CancelSale
{
    public sealed record CancelItemCommand(Guid SaleId, Guid ItemId) : IRequest<bool>;
}
