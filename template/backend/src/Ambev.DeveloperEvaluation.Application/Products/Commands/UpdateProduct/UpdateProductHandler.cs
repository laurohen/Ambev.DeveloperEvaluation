using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, UpdateProductResult?>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<UpdateProductResult?> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetByIdAsync(command.Id, cancellationToken);

            if (product == null)
                return null;

            var rate = command.Rating.Rate;
            var count = command.Rating.Count;

            product.UpdateDetails(
                command.Title,
                command.Price,
                command.Description,
                command.Image,
                command.Category,
                rate,
                count
            );

            var updatedProduct = await _productRepository.UpdateAsync(product, cancellationToken);

            return _mapper.Map<UpdateProductResult>(updatedProduct);
        }
    }
}
