using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL.Interfaces.IEntities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string Name { get; set; }
    }
}
