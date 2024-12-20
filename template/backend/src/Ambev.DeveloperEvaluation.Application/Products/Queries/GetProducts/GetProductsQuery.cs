﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProducts
{
    public record GetProductsQuery : IRequest<GetProductsResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
        public string? Order { get; set; }
        public Dictionary<string, string> Filters { get; set; } = new();
    }

    public record GetProductsResponse(List<GetProductsProductDto> Products, int TotalItems, int TotalPages);
    public record GetProductsProductDto(int Id, string Title, decimal Price, string Category, string Image);
}
