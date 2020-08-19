using BicycleRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleRent.DAL.DataSeeding
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            BicycleType road = new BicycleType { Id = Guid.NewGuid(), Name = "Road" };
            BicycleType city = new BicycleType { Id = Guid.NewGuid(), Name = "City" };
            BicycleType hybrid = new BicycleType { Id = Guid.NewGuid(), Name = "Hybrid" };
            BicycleType mountain = new BicycleType { Id = Guid.NewGuid(), Name = "Mountain" };

            Bicycle ardisSantana = new Bicycle { Id = Guid.NewGuid(), Name = "Ardis Santana", Price = 10.99, TypeId = city.Id, RentalStatus = true };
            Bicycle orbeaVector = new Bicycle { Id = Guid.NewGuid(), Name = "Orbea Vector", Price = 15.99, TypeId = city.Id, RentalStatus = true };
            Bicycle crossrideShark = new Bicycle { Id = Guid.NewGuid(), Name = "Crossride Shark", Price = 10.99, TypeId = mountain.Id, RentalStatus = true };
            Bicycle ghostTacana = new Bicycle { Id = Guid.NewGuid(), Name = "Ghost Tacana", Price = 8.50, TypeId = mountain.Id, RentalStatus = true };
            Bicycle corradoNamito = new Bicycle { Id = Guid.NewGuid(), Name = "Corrado Namitoa", Price = 13.50, TypeId = mountain.Id, RentalStatus = true };
            Bicycle ventoMonte = new Bicycle { Id = Guid.NewGuid(), Name = "Vento Monte", Price = 9.50, TypeId = mountain.Id, RentalStatus = true };
            Bicycle bergamontHelix = new Bicycle { Id = Guid.NewGuid(), Name = "Bergamont Helix", Price = 10.50, TypeId = hybrid.Id, RentalStatus = true };
            Bicycle authorCompact = new Bicycle { Id = Guid.NewGuid(), Name = "Author Compact", Price = 10.99, TypeId = hybrid.Id, RentalStatus = true };
            Bicycle trinxTempo = new Bicycle { Id = Guid.NewGuid(), Name = "TRINX Tempo", Price = 9.99, TypeId = road.Id, RentalStatus = true };
            Bicycle orbeaAvant = new Bicycle { Id = Guid.NewGuid(), Name = "Orbea Avant", Price = 14.50, TypeId = road.Id, RentalStatus = true };
            Bicycle bergamontPrime = new Bicycle { Id = Guid.NewGuid(), Name = "Bergamont PRIME", Price = 16.99, TypeId = road.Id, RentalStatus = true };

            modelBuilder.Entity<BicycleType>().HasData(road, city, hybrid, mountain);
            modelBuilder.Entity<Bicycle>().HasData(ardisSantana, orbeaVector,crossrideShark,ghostTacana,corradoNamito,ventoMonte,bergamontHelix,authorCompact,trinxTempo,orbeaAvant,bergamontPrime);
        }
    }
}
