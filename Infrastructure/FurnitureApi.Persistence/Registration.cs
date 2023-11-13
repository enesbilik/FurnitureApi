using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using FurnitureApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using FurnitureApi.Application.Interfaces.Repositories;
using FurnitureApi.Persistence.UnitOfWorks;
using FurnitureApi.Application.Interfaces.UnitOfWorks;
using FurnitureApi.Persistence.Repositories;

namespace FurnitureApi.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

        }

    }
}

