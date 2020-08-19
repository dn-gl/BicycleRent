using BicycleRent.DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepositoy<TEntity> where TEntity : class
    {
        protected readonly BicycleRentDbContext context;

        public BaseRepository(BicycleRentDbContext context)
        {
            this.context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
