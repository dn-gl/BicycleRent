using BicycleRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BicycleRent.DAL.Configurations
{
    public class BicycleTypeConfiguration : IEntityTypeConfiguration<BicycleType>
    {
        public void Configure(EntityTypeBuilder<BicycleType> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
