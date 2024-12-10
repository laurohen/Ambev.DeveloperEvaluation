using Ambev.DeveloperEvaluation.Domain.Models.ProductAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Commands.CreateProduct
{
    public class CreateProductProfile : Profile
    {
        public CreateProductProfile()
        {
            //CreateMap<CreateProductCommand, Product>()
            //.ConstructUsing(command =>
            //    new Product(
            //        command.Title,
            //        command.Price,
            //        command.Description,
            //        command.Image,
            //        new ProductRating(Guid.NewGuid(), (decimal)command.Rating.Rate, command.Rating.Count),
            //        Guid.NewGuid() 
            //    )
            //);


            //CreateMap<Product, CreateProductResult>()
            //    .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new ProductRatingDto((double)src.Rating.Rate, src.Rating.Count)));

            CreateMap<CreateProductCommand, Product>()
            .ForMember(dest => dest.CategoryId, opt => opt.Ignore()) 
            .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new ProductRating(Guid.NewGuid(), src.Rating.Rate, src.Rating.Count)));

            CreateMap<Product, CreateProductResult>()
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new ProductRatingDto(src.Rating.Rate, src.Rating.Count)));

            //CreateMap<CreateProductCommand, Product>();
            //CreateMap<Product, CreateProductResult>();
            CreateMap<ProductRatingDto, ProductRating>().ReverseMap();
        }
    }
}
