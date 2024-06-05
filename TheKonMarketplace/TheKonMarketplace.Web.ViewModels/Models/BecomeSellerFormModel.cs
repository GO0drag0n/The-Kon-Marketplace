using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Web.ViewModels.Models
{
    public class BecomeSellerFormModel
    {
        [Required(ErrorMessage = "Enter a valid phone number.")]
        [Phone]
        [StringLength(10, MinimumLength = 10)]
        public string PhoneNumber { get; set; } = null!;

    }
}
