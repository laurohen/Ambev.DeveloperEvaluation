using Ambev.DeveloperEvaluation.Application.Products.DTOs;
using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductsByCategory
{
    /// <summary>
    /// Profile for mapping GetProductsByCategory operations.
    /// </summary>
    public class GetProductsByCategoryProfile : Profile
    {
        public GetProductsByCategoryProfile()
        {
            CreateMap<Product, ProductDto>();
        }
    }
}
