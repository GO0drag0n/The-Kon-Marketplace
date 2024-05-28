using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKonMarketplace.Data.Models.Constants;

namespace TheKonMarketplace.Web.ViewModels.Models
{
    public class CreateOfferViewModel
    {
        [Required]
        [StringLength(EntityConstants.OfferConstants.TitleMaxLenght)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(EntityConstants.BreedConstants.NameMaxLength)]
        public string Breed { get; set; } = null!;
        [StringLength(EntityConstants.OfferConstants.DescriptionMaxLenght)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;
        [Required]
        [Range(EntityConstants.OfferConstants.PriceMinValue, EntityConstants.OfferConstants.PriceMaxValue)]
        public decimal Price { get; set; }

        public string Location { get; set; } = null!;
    }
}
