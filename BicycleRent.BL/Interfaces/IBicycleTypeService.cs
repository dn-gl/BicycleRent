using BicycleRent.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BicycleRent.BL.Interfaces
{
    public interface IBicycleTypeService
    {
        Task<IEnumerable<BicycleType>> GetAll();
    }
}
