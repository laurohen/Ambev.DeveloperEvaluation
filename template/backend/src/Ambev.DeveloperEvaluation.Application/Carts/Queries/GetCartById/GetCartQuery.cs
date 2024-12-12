using Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCart;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.DeveloperEvaluation.Application.Carts.Queries.GetCartById
{
    /// <summary>
    /// Query to retrieve a specific cart by ID.
    /// </summary>
    public class GetCartQuery : IRequest<GetCartResult>
    {
        /// <summary>
        /// The unique identifier of the cart to retrieve.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Initializes a new instance of the GetCartQuery class.
        /// </summary>
        /// <param name="id">The unique identifier of the cart.</param>
        public GetCartQuery(Guid id)
        {
            Id = id;
        }
    }

}
