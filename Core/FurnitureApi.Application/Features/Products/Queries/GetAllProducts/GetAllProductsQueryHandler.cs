using System;
using FurnitureApi.Application.DTOs;
using FurnitureApi.Application.Interfaces.AutoMapper;
using FurnitureApi.Application.Interfaces.UnitOfWorks;
using FurnitureApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x => x.Include(b => b.Category));

            var category = mapper.Map<CategoryDto, Category>(new Category());

            var map = mapper.Map<GetAllProductsQueryResponse, Product>(products);

            return map;
        }
    }
}

