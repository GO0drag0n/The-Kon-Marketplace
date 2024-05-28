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
    public class User : IdentityUser
    {
        
        public User()
        {
        }
        public ICollection<Offer> SellerOffers { get; set; }
    }
}
