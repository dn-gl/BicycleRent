using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BicycleRent.BL.Interfaces;
using BicycleRent.DAL.Entities;
using BicycleRent.Web.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace BicycleRent.Web.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class BicycleController : ControllerBase
    {
        private readonly IBicycleService bicycleService;
        private readonly IBicycleTypeService bicycleTypeService;
        private readonly IMapper mapper;

        public BicycleController(IBicycleService bicycleService, IBicycleTypeService bicycleTypeService, IMapper mapper)
        {
            this.bicycleService = bicycleService;
            this.bicycleTypeService = bicycleTypeService;
            this.mapper = mapper;
        }

        [HttpGet("GetTypes")]
        public async Task<IEnumerable<BicycleTypeApiModel>> GetTypes()
        {
            var bt = await bicycleTypeService.GetAll();
            IEnumerable<BicycleTypeApiModel> btApi = mapper.Map<IEnumerable<BicycleType>, IEnumerable<BicycleTypeApiModel>>(bt);
            return btApi;
        }

        [HttpGet("GetRented")]
        public async Task<IEnumerable<BicycleApiModel>> GetRented()
        {
            var model = await bicycleService.GetRented();
            IEnumerable<BicycleApiModel> bicycles = mapper.Map<IEnumerable<Bicycle>, IEnumerable<BicycleApiModel>>(model);
            return bicycles;
        }

        [HttpGet("GetAvailable")]
        public async Task<IEnumerable<BicycleApiModel>> GetAvailable()
        {
            var model = await bicycleService.GetAvailable();
            IEnumerable<BicycleApiModel> bicycles = mapper.Map<IEnumerable<Bicycle>, IEnumerable<BicycleApiModel>>(model);
            return bicycles;
        }

        [HttpPost("Create")]
        public async Task<Bicycle> Create(BicycleApiModel model)
        {
            Bicycle bicycle = mapper.Map<BicycleApiModel, Bicycle>(model);
            bicycle.Id = Guid.NewGuid();
            //bicycle.TypeId = model.Type.Id;

            return await bicycleService.Add(bicycle);
        }

        [HttpPost("UpdateRentalStatus")]
        public async Task UpdateRentalStatus(BicycleApiModel model)
        {
            Bicycle bicycle = mapper.Map<BicycleApiModel, Bicycle>(model);
            bicycle.TypeId = model.Type.Id;

            await bicycleService.Update(bicycle);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await bicycleService.Delete(id);
        }
    }
}
