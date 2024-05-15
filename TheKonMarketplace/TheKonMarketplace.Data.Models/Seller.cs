using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheKonMarketplace.Data.Models
{
    using static Constants.EntityConstants.SellerConstants;
    public class Seller
    {
        
        public Seller()
        {
            SellerOffers = new HashSet<Offer>();
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Phone]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;

        public ICollection<Offer> SellerOffers { get; set; }
    }
}
