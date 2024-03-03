using System;
using FurnitureApi.Application.Interfaces.UnitOfWorks;
using FurnitureApi.Domain.Entities;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = new Product(request.Title, request.Description, request.Price, request.CategoryId);
            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);

            await unitOfWork.SaveAsync();

        }
    }
}

