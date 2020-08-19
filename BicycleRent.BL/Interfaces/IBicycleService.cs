using BicycleRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.BL.Interfaces
{
    public interface IBicycleService : IBaseService<Bicycle>
    {
        Task<IEnumerable<Bicycle>> GetAvailable();
        Task<IEnumerable<Bicycle>> GetRented();
    }
}
