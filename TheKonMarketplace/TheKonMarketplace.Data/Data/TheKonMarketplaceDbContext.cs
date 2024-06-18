using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TheKonMarketplace.Data.Models;
using TheKonMarketplace.Data.Models.Configurations;

namespace TheKonMarketplace.Data.Data
{
    public class TheKonMarketplaceDbContext : IdentityDbContext<Seller>
    {
        public TheKonMarketplaceDbContext(DbContextOptions<TheKonMarketplaceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply external configurations
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new IdentityUserConfiguration());
            builder.ApplyConfiguration(new SellerConfiguration());
            builder.ApplyConfiguration(new OfferConfiguration());

            // Seed data
            /*var sellerId = "sample-seller-id";
            var hasher = new PasswordHasher<Seller>();

            builder.Entity<Seller>().HasData(
                new Seller
                {
                    Id = sellerId,
                    UserName = "seller@example.com",
                    NormalizedUserName = "SELLER@EXAMPLE.COM",
                    Email = "seller@example.com",
                    NormalizedEmail = "SELLER@EXAMPLE.COM",
                    PhoneNumber = "1234567890",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password123")
                }
            );

            builder.Entity<Offer>().HasData(
                new Offer
                {
                    Id = 1,
                    Title = "Sample Offer",
                    Location = "Sample Location",
                    Description = "Sample Description",
                    ImageUrl = "http://example.com/image.jpg",
                    Price = 100m,
                    BreedId = 1,
                    UserId = sellerId // Correctly set the foreign key
                }
            );*/
        }
    }
}
