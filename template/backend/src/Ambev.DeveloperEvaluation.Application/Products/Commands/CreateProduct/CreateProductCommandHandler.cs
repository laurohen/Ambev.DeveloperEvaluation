using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    //public class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    //: IRequestHandler<CreateProductCommand, CreateProductResult>
    //{
    //    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    //    {
    //        var validator = new CreateProductCommandValidator();
    //        var validationResult = await validator.ValidateAsync(command, cancellationToken);

    //        if (!validationResult.IsValid)
    //            throw new ValidationException(validationResult.Errors);

    //        var product = mapper.Map<Product>(command);

    //        var createdProduct = await productRepository.CreateAsync(product, cancellationToken);
    //        var result = mapper.Map<CreateProductResult>(createdProduct);
    //        return result;
    //    }
    //}
}
