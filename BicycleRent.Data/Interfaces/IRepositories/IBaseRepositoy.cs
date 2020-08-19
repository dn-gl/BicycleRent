using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Interfaces.IRepositories
{
    public interface IBaseRepositoy<TEntity>
    {
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Update(TEntity entity);
    }
}
