using System;
using FurnitureApi.Domain.Common;

namespace FurnitureApi.Domain.Entities
{
    public class Category : EntityBase
    {

        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}


