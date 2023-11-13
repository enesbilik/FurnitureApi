using System;
using FurnitureApi.Application.DTOs;
using FurnitureApi.Domain.Entities;

namespace FurnitureApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public CategoryDto Category { get; set; }

    }
}

