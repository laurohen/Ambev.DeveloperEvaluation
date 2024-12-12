using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ambev.DeveloperEvaluation.Domain.Models.CategoryAggregate;
using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the CreateProductHandler.
        /// </summary>
        /// <param name="productRepository">The product repository for database operations.</param>
        /// <param name="mapper">The mapper for converting between models.</param>
        public CreateProductHandler(IProductRepository productRepository, ICategoryRepository categoryRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Handles the CreateProductCommand request.
        /// </summary>
        /// <param name="command">The CreateProduct command.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>The created product details.</returns>
        public async Task<CreateProductResult?> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateProductCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);
            //if (!validationResult.IsValid)
            //    throw new ValidationException(validationResult.Errors);

            if (!validationResult.IsValid)
            {
                return new CreateProductResult
                {
                    Success = false,
                    Message = "Validation failed.",
                    Errors = validationResult.Errors.Select(e => new ValidationErrorDetail
                    {
                        PropertyName = e.PropertyName,
                        ErrorMessage = e.ErrorMessage
                    }).ToList()
                };
            }

            var category = await _categoryRepository.GetByNameAsync(command.Category, cancellationToken);
            if (category == null)
            {
                return new CreateProductResult
                {
                    Success = false,
                    Message = $"Category '{command.Category}' not found.",
                    Errors = new List<ValidationErrorDetail>
                    {
                        new ValidationErrorDetail
                        {
                            PropertyName = "Category",
                            ErrorMessage = "The specified category does not exist."
                        }
                    }
                };
            }

            var product = _mapper.Map<Product>(command);
            product.AssignCategory(category.Id);

            var createdProduct = await _productRepository.CreateAsync(product, cancellationToken);

            var result = _mapper.Map<CreateProductResult>(createdProduct);
            result.Success = true;
            result.Message = "Product created successfully.";
            return result;
        }
    }

}
