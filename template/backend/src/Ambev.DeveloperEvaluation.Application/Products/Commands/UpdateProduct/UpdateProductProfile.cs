using Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductProfile : Profile
    {
        public UpdateProductProfile()
        {
            CreateMap<UpdateProductCommand, Product>();
            CreateMap<Product, UpdateProductResult>();
            CreateMap<ProductRatingDto, ProductRating>().ReverseMap();
        }
    }
}
