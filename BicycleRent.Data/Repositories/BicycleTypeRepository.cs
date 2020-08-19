using BicycleRent.DAL.Entities;
using BicycleRent.DAL.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Repositories
{
    public class BicycleTypeRepository : IBicycleTypeRepository
    {
        private readonly BicycleRentDbContext context;
        public BicycleTypeRepository(BicycleRentDbContext context)
        {
            this.context = context;
        }

        public void AddRange(IEnumerable<BicycleType> range)
        {
            context.Types.AddRange(range);
        }

        public async Task<IEnumerable<BicycleType>> GetAll()
        {
            return await context.Types.AsNoTracking().ToArrayAsync();
        }
    }
}
