using System;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandRequest : IRequest
    {
        public int Id { get; set; }

    }
}

