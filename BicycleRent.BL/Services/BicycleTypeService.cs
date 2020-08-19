using BicycleRent.BL.Interfaces;
using BicycleRent.DAL.Entities;
using BicycleRent.DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.BL.Services
{
    public class BicycleTypeService : IBicycleTypeService
    {
        private readonly IBicycleTypeRepository bicycleTypeRepositoy;

        public BicycleTypeService(IBicycleTypeRepository bicycleTypeRepositoy)
        {
            this.bicycleTypeRepositoy = bicycleTypeRepositoy;
        }

        public async Task<IEnumerable<BicycleType>> GetAll()
        {
            return await bicycleTypeRepositoy.GetAll();
        }
    }
}
