using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheKonMarketplace.Data.Models
{
    using static Constants.EntityConstants.OfferConstants;
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(LoactionMaxLenght)] 
        public string Location { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(PriceMinValue, PriceMaxValue)]
        [Column(TypeName = "decimal(12,3)")]
        public decimal Price { get; set; }

        [Required]
        [ForeignKey(nameof(Breed))]
        public int BreedId { get; set; }
        public Breed Breed { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public Seller User { get; set; } = null!;
        
        public DateTime CreatedAt { get; set; }




    }
}
