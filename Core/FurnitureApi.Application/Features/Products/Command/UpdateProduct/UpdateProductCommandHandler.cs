using System;
using FurnitureApi.Application.Interfaces.AutoMapper;
using FurnitureApi.Application.Interfaces.UnitOfWorks;
using FurnitureApi.Domain.Entities;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<Product, UpdateProductCommandRequest>(request);

            await unitOfWork.GetWriteRepository<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();
        }
    }
}

