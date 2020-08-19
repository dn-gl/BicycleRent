using BicycleRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Interfaces.IRepositories
{
    public interface IBicycleTypeRepository
    {
        void AddRange(IEnumerable<BicycleType> range);
        Task<IEnumerable<BicycleType>> GetAll();
    }
}
