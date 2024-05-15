using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TheKonMarketplace.Web.ViewModels.Models
{
    public class HorseDetailsViewModel : Controller
    {
        [Required]
        public string HorseName { get; set; } = null!;
        [Required]
        public string HorseBreed { get; set; } = null!;
        public string HorseDescription { get; set; } = null!;
        [Required]
        public string HorseLocation { get; set; } = null!;
        [Required]
        public string HorseImgUrl { get; set; } = null!;
        [Required]
        public decimal HorsePrice { get; set; }
        [Required]
        public string HorseSellerId { get; set; } = null!;



    }
}
