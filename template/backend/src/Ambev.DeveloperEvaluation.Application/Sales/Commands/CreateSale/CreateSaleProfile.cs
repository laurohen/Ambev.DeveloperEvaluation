using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Dtos;
using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.CreateSale
{
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleCommand, Sale>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
                .ReverseMap();

            CreateMap<SaleItemDto, SaleItem>().ReverseMap();

            CreateMap<Sale, CreateSaleResult>().ReverseMap();
        }
    }
}
