using Ambev.DeveloperEvaluation.Domain.Models.CartAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Commands.CreateCart
{
    public class CreateOrUpdateCartProfile : Profile
    {
        public CreateOrUpdateCartProfile()
        {
            CreateMap<Cart, CreateOrUpdateCartResult>().ReverseMap();
        }
    }
}
