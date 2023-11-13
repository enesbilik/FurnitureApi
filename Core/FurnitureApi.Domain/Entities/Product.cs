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

        public string Title { get; set; }
        public string Description { get; set; }
        // public  string ImagePath{ get; set; 
        public double Price { get; set; }
        public double Rating { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}

