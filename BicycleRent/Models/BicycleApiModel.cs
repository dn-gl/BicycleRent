using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRent.Web.Models
{
    public class BicycleApiModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool RentalStatus { get; set; } = true;
        public Guid TypeId { get; set; }
        public BicycleTypeApiModel Type { get; set; }
    }
}
