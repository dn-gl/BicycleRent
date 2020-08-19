using BicycleRent.BL.Interfaces;
using BicycleRent.BL.Services;
using BicycleRent.DAL.Entities;
using BicycleRent.DAL.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.BL.IoC
{
    public static class BlDependencies
    {
        public static void RegisterBlDependency(this IServiceCollection collection)
        {
            collection.AddScoped<IBicycleService, BicycleService>();
            collection.AddScoped<IBicycleTypeService, BicycleTypeService>();

            collection.RegisterDalDependencies();
        }
    }
}
