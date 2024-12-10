using Ambev.DeveloperEvaluation.Domain.Models.CustomerAggregate.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Customers.Commands.CreateCustomer
{
    public class CreateCustomerProfile : Profile
    {
        public CreateCustomerProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>()
                .ReverseMap();
            CreateMap<Customer, CreateCustomerResult>()
                .ReverseMap();
        }
    }
}
