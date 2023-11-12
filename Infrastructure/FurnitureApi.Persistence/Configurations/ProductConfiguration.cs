using System;
using FurnitureApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            var product1 = new Product()
            {
                Id = 1,
                Title = "Comfortable Sofa",
                Description = "Lorem ipsum Dolor sit amet",
                Price = 19.40,
                Rating = 4.5,
                CategoryId = 1000

            };

            var product2 = new Product()
            {
                Id = 2,
                Title = "Leather Chair",
                Description = "Lorem ipsum Dolor sit amet",
                Price = 29.99,
                Rating = 4.0,
                CategoryId = 1002

            };

            var product3 = new Product()
            {
                Id = 3,
                Title = "Modern Table",
                Description = "Lorem ipsum Dolor sit amet",
                Price = 39.99,
                Rating = 4.2,
                CategoryId = 1003

            };

            var product4 = new Product()
            {
                Id = 4,
                Title = "King-sized Bed",
                Description = "Lorem ipsum Dolor sit amet",
                Price = 99.99,
                Rating = 4.8,
                CategoryId = 1004

            };
            var product5 = new Product()
            {
                Id = 5,
                Title = "Sofa Later",
                Description = "Lorem ipsum Dolor sit amet",
                Price = 59.40,
                Rating = 3.5,
                CategoryId = 1000

            };

            builder.HasData(product1, product2, product3, product4, product5);

        }
    }
}

