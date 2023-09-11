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
    internal class SellerConfig : IEntityTypeConfiguration<Seller>
    {

        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Boughts).WithOne(x => x.Seller);

        }
    }
    
    
}
