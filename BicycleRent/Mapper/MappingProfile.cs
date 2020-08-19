using AutoMapper;
using BicycleRent.DAL.Entities;
using BicycleRent.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRent.Web.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Bicycle, BicycleApiModel>();
            CreateMap<BicycleApiModel, Bicycle>();
            CreateMap<BicycleType, BicycleTypeApiModel>();
            CreateMap<BicycleTypeApiModel, BicycleType>();
        }
    }
}
