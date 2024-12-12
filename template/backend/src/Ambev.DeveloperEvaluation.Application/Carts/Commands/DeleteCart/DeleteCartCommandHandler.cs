using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.DeleteCart
{
    public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, bool>
    {
        private readonly ICartRepository _repository;

        public DeleteCartCommandHandler(ICartRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
        {
            return await _repository.DeleteAsync(request.Id, cancellationToken);
        }
    }
}
