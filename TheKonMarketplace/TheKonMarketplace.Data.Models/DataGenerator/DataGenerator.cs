using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Data.Models.DataGenerator
{
    using static TheKonMarketplace.Data.Models.Constants.EntityConstants;
    public class DataGenerator
    {

        public static IEnumerable<IdentityUser> SeedUsers()
        {
            IEnumerable<IdentityUser> users = new List<IdentityUser>()
            {
                new IdentityUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "agent@mail.com",
                    NormalizedUserName = "AGENT@MAIL.COM",
                    Email = "agent@mail.com",
                    NormalizedEmail = "AGENT@MAIL.COM",
                    PhoneNumber = "+359888888888",
                },
                new IdentityUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest@mail.com",
                    NormalizedUserName = "GUEST@MAIL.COM",
                    Email = "guest@mail.com",
                    NormalizedEmail = "GUEST@MAIL.COM"
                }
            };

            var hasher = new PasswordHasher<IdentityUser>();
            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, DefaultPassword);
            }

            return users;
        }

        public static IEnumerable<Breed> SeedBreeds()
        {
            var categories = new List<Breed>()
            {
                new Breed()
                {
                    Id = 1,
                    Name = "American Quarter Horse"
                },
                new Breed()
                {
                    Id = 2,
                    Name = "Arabian"
                },
                new Breed()
                {
                    Id = 3,
                    Name = "Thoroughbred"
                },
            };

            return categories;
        }

        public static IEnumerable<IdentityRole> SeedRoles() 
        {
            return new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "484d5e1f-080d-4bc6-a5be-fbab112098b2",
                    Name = "Seller",
                    NormalizedName = "SELLER"
                },
                new IdentityRole()
                {
                    Id = "08e9b95d-3b67-46e5-bdd5-8f850ed416e6",
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
        }

        public static IEnumerable<Offer> SeedOffer()
        {
            var houses = new List<Offer>()
            {
                new Offer()
                {
                    Id = 1,
                    Title = "Thoroughbred - Hasan",
                    Location = "North London, UK (near the border)",
                    Description = "5 year old Horse at its prime",
                    ImageUrl = "https://horseyhooves.com/wp-content/uploads/2020/10/American-Quarter-Horse-1.jpg",
                    Price = 2100.00M,
                    BreedId = 3,
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Offer()
                {
                    Id = 2,
                    Title = "Thoroughbred - Anton",
                    Location = "Albania",
                    Description = "12 year for sudjuk",
                    ImageUrl = "https://horseyhooves.com/wp-content/uploads/2022/03/Beautiful-black-Friesian-horse-standing-in-a-grass-paddock.jpg.webp",
                    Price = 1500.00M,
                    BreedId = 3,
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                },
                new Offer()
                {
                    Id = 3,
                    Title = "Arabian - Muhamed",
                    Location = "Albania, Kosovo",
                    Description = "Very fast horse",
                    ImageUrl = "https://horseyhooves.com/wp-content/uploads/2020/10/Arabian-horse-breed-1.jpg",
                    Price = 2100.00M,
                    BreedId = 2,
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                }
            };

            return houses;
        }

    }
}
