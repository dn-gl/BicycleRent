using BicycleRent.DAL.Entities;
using BicycleRent.DAL.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Repositories
{
    public class BicycleRepositoty : BaseRepository<Bicycle>, IBicycleRepository
    {
        public BicycleRepositoty(BicycleRentDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Bicycle>> GetAvailable()
        {
            return await context.Bicycles.Where(x => x.RentalStatus == true).Include(x => x.Type).AsNoTracking().ToArrayAsync();
        }

        public async Task<IEnumerable<Bicycle>> GetRented()
        {
            return await context.Bicycles.Where(x => x.RentalStatus == false).Include(x => x.Type).AsNoTracking().ToArrayAsync();
        }
    }
}
