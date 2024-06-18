using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheKonMarketplace.Data.Models
{
    using static Constants.EntityConstants.SellerConstants;
    public class Seller : IdentityUser
    {

        public ICollection<Offer> Offers { get; set; } = new List<Offer>();

    }
}
