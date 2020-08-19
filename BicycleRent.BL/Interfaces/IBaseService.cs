using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.BL.Interfaces
{
    public interface IBaseService<TEntity>
    {
        Task<TEntity> GetById(Guid id);
        Task<TEntity> Add(TEntity entity);
        Task Delete(Guid id);
        Task Update(TEntity entity);
    }
}
