using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCartById
{
    public class GetCartByIdQueryHandler : IRequestHandler<GetCartByIdQuery, GetCartByIdResponse?>
    {
        private readonly ICartRepository _repository;
        private readonly IMapper _mapper;

        public GetCartByIdQueryHandler(ICartRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetCartByIdResponse?> Handle(GetCartByIdQuery request, CancellationToken cancellationToken)
        {
            var cart = await _repository.GetByIdAsync(request.Id, cancellationToken);
            return cart == null ? null : _mapper.Map<GetCartByIdResponse>(cart);
        }
    }
}
