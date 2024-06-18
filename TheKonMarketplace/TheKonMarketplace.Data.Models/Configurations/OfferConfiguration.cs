using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Data.Models.Configurations
{
    using DataGenerator;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
/*            builder.Property(o => o.Title).IsRequired().HasMaxLength(100);
            builder.HasOne(o => o.Seller)
                   .WithMany(s => s.Offers)
                   .HasForeignKey(o => o.UserId)
                   .IsRequired(); 
*/

            /*builder.HasData(DataGenerator.SeedOffer());*/
        }

    }
}
