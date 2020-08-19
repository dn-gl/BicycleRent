using BicycleRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.DAL.Interfaces.IRepositories
{
    public interface IBicycleRepository : IBaseRepositoy<Bicycle>
    {
        Task<IEnumerable<Bicycle>> GetAvailable();
        Task<IEnumerable<Bicycle>> GetRented();
    }
}
