﻿using System;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandRequest : IRequest
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public int CategoryId { get; set; }
    }
}

