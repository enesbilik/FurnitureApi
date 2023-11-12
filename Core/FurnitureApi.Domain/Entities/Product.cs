using System;
using FurnitureApi.Domain.Common;

namespace FurnitureApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {

        }

        public Product(
            string title,
            string description,
            double price,
            double rating)
        {
            Title = title;
            Description = description;
            Price = price;
            Rating = rating;
        }

        public required string Title { get; set; }
        public required string Description { get; set; }
        // public required string ImagePath{ get; set; 
        public required double Price { get; set; }
        public required double Rating { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

