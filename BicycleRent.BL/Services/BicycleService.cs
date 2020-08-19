using BicycleRent.BL.Interfaces;
using BicycleRent.DAL.Entities;
using BicycleRent.DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.BL.Services
{
    public class BicycleService : IBicycleService
    {
        private readonly IBicycleRepository bicycleRepository;

        public BicycleService(IBicycleRepository bicycleRepository)
        {
            this.bicycleRepository = bicycleRepository;
        }

        public async Task<Bicycle> Add(Bicycle entity)
        {
            return await bicycleRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            Bicycle entity = await GetById(id);
            await bicycleRepository.Delete(entity);
        }

        public async Task<IEnumerable<Bicycle>> GetAvailable()
        {
            return await bicycleRepository.GetAvailable();
        }

        public async Task<Bicycle> GetById(Guid id)
        {
            return await bicycleRepository.GetById(id);
        }

        public async Task<IEnumerable<Bicycle>> GetRented()
        {
            return await bicycleRepository.GetRented();
        }

        public async Task Update(Bicycle entity)
        {
            await bicycleRepository.Update(entity);
        }
    }
}
