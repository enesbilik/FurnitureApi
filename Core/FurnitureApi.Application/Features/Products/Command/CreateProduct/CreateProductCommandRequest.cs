using System;
using FurnitureApi.Domain.Entities;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}

