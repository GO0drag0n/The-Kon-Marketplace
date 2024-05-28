using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheKonMarketplace.Data.Models;
using static TheKonMarketplace.Data.Models.Configurations.IdentityUserConfiguration;
using TheKonMarketplace.Data.Models.Configurations;

namespace TheKonMarketplace.Data.Data
{
    public class TheKonMarketplaceDbContext : IdentityDbContext<User>
    {
        
        public TheKonMarketplaceDbContext(DbContextOptions<TheKonMarketplaceDbContext> options)
            : base(options)
        {
        }
        

        public override DbSet<User> Users { get; set; } = null!;
        public DbSet<Breed> Breeds { get; set; } = null!;
        public DbSet<Offer> Offers { get; set; } = null!;
         
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new IdentityUserConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new BreedConfiguration());
            builder.ApplyConfiguration(new OfferConfiguration());

            base.OnModelCreating(builder);
        }

    }
} 