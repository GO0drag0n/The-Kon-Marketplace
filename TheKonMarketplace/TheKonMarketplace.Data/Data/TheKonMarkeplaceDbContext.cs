using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheKonMarketplace.Data.Models;
using static TheKonMarketplace.Data.Models.Configurations.IdentityUserConfiguration;
using TheKonMarketplace.Data.Models.Configurations;

namespace TheKonMarketplace.Data.Data
{
    public class TheKonMarkeplaceDbContext : IdentityDbContext
    {
        
        public TheKonMarkeplaceDbContext(DbContextOptions<TheKonMarkeplaceDbContext> options)
            : base(options)
        {
        }


        public DbSet<Seller> Sellers { get; set; } = null!;
        public DbSet<Breed> Breeds { get; set; } = null!;
        public DbSet<Offer> Offers { get; set; } = null!;
         
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IdentityUserConfiguration() );
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new BreedConfiguration());
            builder.ApplyConfiguration(new OfferConfiguration());

            base.OnModelCreating(builder);
        }

    }
} 