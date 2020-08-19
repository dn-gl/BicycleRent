using BicycleRent.DAL.Entities;
using BicycleRent.DAL.Interfaces.IRepositories;
using BicycleRent.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL.IoC
{
    public static class DalDependencies
    {
        public static void RegisterDalDependencies(this IServiceCollection collection)
        {
            collection.AddScoped<IBicycleRepository, BicycleRepositoty>();
            collection.AddScoped<IBicycleTypeRepository, BicycleTypeRepository>();
        }
    }
}
