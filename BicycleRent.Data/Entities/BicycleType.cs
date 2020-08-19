using BicycleRent.DAL.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL.Entities
{
    public class BicycleType : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
