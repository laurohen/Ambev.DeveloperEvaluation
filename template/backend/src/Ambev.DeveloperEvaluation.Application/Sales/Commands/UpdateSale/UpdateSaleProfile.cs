using Ambev.DeveloperEvaluation.Domain.Models.SaleAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Sales.Commands.UpdateSale
{
    public class UpdateSaleProfile : Profile
    {
        public UpdateSaleProfile()
        {
            CreateMap<UpdateSaleCommand, Sale>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items))
                .ReverseMap();

            CreateMap<Sale, UpdateSaleResult>().ReverseMap();
        }
    }
}
