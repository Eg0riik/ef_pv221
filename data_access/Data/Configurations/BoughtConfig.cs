using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using data_access.Entities;

namespace _01_intro_to_ef.Data.Configurations
{
    internal class BoughtConfig : IEntityTypeConfiguration<Bought>
    {
        
            public void Configure(EntityTypeBuilder<Bought> builder)
            {
              builder.HasKey(x => x.Id);
               builder.HasOne(x => x.Seller).WithMany(x => x.Boughts);
               builder.HasOne(x => x.Buyer).WithMany(x => x.Boughts);
               builder.HasMany(x => x.MusicRecords).WithMany(x => x.Boughts);
        }
    }
}
