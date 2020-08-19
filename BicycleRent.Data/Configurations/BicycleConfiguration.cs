using BicycleRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL.Configurations
{
    public class BicycleConfiguration : IEntityTypeConfiguration<Bicycle>
    {
        public void Configure(EntityTypeBuilder<Bicycle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Type);
        }
    }
}
