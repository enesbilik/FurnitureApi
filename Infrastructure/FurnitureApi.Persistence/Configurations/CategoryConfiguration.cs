using System;
using FurnitureApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FurnitureApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var category1 = new Category() { Id = 1000, Name = "Sofa" };
            var category2 = new Category() { Id = 1002, Name = "Chair" };
            var category3 = new Category() { Id = 1003, Name = "Table" };
            var category4 = new Category() { Id = 1004, Name = "Bed" };

            builder.HasData(category1, category2, category3, category4);

        }
    }
}

