using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    /// <summary>
    /// Profile for mapping CreateCart operations.
    /// </summary>
    public class CreateCartProfile : Profile
    {
        public CreateCartProfile()
        {
            CreateMap<CreateCartCommand, Cart>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
            CreateMap<CreateCartItemDto, CartItem>();

            CreateMap<Cart, CreateCartResult>()
                .ForMember(dest => dest.Products, opt => opt.MapFrom(src => src.Products));
            CreateMap<CartItem, CreateCartItemDto>();
        }
    }
}
