using BicycleRent.DAL.Interfaces.IEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL.Entities
{
    public class Bicycle : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool RentalStatus { get; set; }
        public Guid TypeId { get; set; }
        public virtual BicycleType Type { get; set; }
    }
}
