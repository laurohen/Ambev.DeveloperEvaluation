﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Products.Queries.GetProductById
{
    public record GetProductByIdQuery : IRequest<GetProductByIdResponse>
    {
        public int Id { get; set; }
    }

    public record GetProductByIdResponse(
        int Id,
        string Title,
        decimal Price,
        string Description,
        string Category,
        string Image,
        GetProductByIdRatingDto Rating
    );

    public record GetProductByIdRatingDto(decimal Rate, int Count);
}
