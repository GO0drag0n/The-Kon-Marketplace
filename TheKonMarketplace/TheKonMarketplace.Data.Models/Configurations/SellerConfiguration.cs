﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Data.Models.Configurations
{
    using DataGenerator;
    using Microsoft.EntityFrameworkCore;


    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
/*            builder.HasMany(s => s.Offers)
               .WithOne(o => o.Seller)
               .HasForeignKey(o => o.UserId)
               .OnDelete(DeleteBehavior.Cascade);
*/
        }
    }
}
