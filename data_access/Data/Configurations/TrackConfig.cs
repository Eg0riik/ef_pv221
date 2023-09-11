using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data_access.Entities;

namespace _01_intro_to_ef.Data.Configurations
{
    internal class TrackConfig : IEntityTypeConfiguration<Track>
    {

        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Genre).WithMany(x => x.Tracks);
            builder.HasOne(x => x.MusicRecords).WithMany(x => x.Tracks);
            builder.HasOne(x => x.Group).WithMany(x => x.Tracks);

        }
    }
}
