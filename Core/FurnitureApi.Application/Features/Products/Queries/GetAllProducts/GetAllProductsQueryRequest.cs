using System;
using MediatR;

namespace FurnitureApi.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryRequest : IRequest<IList<GetAllProductsQueryResponse>>
    {

    }
}

