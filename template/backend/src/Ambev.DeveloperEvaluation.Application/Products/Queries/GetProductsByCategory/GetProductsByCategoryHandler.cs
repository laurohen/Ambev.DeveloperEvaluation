using Ambev.DeveloperEvaluation.Application.Products.DTOs;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductsByCategory
{
    /// <summary>
    /// Handler for GetProductsByCategoryQuery.
    /// </summary>
    public class GetProductsByCategoryHandler : IRequestHandler<GetProductsByCategoryQuery, PaginatedResult<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsByCategoryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<PaginatedResult<ProductDto>> Handle(GetProductsByCategoryQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetProductsByCategoryAsync(
                request.Category,
                request.Page,
                request.Size,
                request.Order,
                cancellationToken
            );

            var totalItems = products.TotalItems;
            var totalPages = (int)Math.Ceiling((double)totalItems / request.Size);

            return new PaginatedResult<ProductDto>
            {
                Data = _mapper.Map<List<ProductDto>>(products.Items),
                TotalItems = totalItems,
                CurrentPage = request.Page,
                TotalPages = totalPages
            };
        }
    }
}
