using data_access.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_intro_to_ef.Data.Configurations
{
    internal class MusicalRecordConfig : IEntityTypeConfiguration<MusicRecord>
   {
        
            public void Configure(EntityTypeBuilder<MusicRecord> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Group).WithMany(x => x.MusicRecords);
            builder.HasMany(x => x.Tracks).WithOne(x => x.MusicRecords);
            builder.HasMany(x => x.Boughts).WithMany(x => x.MusicRecords);
        }
    }
}
