using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Web.ViewModels.Models
{
    public class OfferViewModel
    {
        [Required(ErrorMessage = "Title should not be empty.")]
        [MinLength(3)]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "Enter a valid breed.")]
        public string Breed { get; set; } = null!;
        [Required(ErrorMessage = "Enter a valid price.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Enter a valid image URL.")]
        public string ImageUrl { get; set; } = null!;

        public int OfferId { get; set; }

    }
}
