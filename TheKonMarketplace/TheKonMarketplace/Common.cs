using Microsoft.AspNetCore.Mvc.DataAnnotations;
using System.Collections.Generic;
using TheKonMarketplace.Web.ViewModels.Models;

namespace TheKonMarketplace
{
    public class Common
    {
        public static IEnumerable<HorseDetailsViewModel> GetHorses()
            => new List<HorseDetailsViewModel>()
            {
                new HorseDetailsViewModel
                {
                    HorseName = "Horse Vihar",
                    HorseDescription = "Very fast horse",
                    HorseLocation = "Razgrad, Bulgaria",
                    HorseImgUrl = "URLHERE",
                    HorsePrice = 2420
                },
                new HorseDetailsViewModel
                {
                    HorseName = "Crimson Runner",
                    HorseDescription = "An agile and quick horse, ideal for racing.",
                    HorseLocation = "Sofia, Bulgaria",
                    HorseImgUrl = "URLHERE",
                    HorsePrice = 2500
                },
                new HorseDetailsViewModel
                {
                    HorseName = "Silver Mist",
                    HorseDescription = "Known for her graceful moves and endurance.",
                    HorseLocation = "Plovdiv, Bulgaria",
                    HorseImgUrl = "URLHERE",
                    HorsePrice = 3000
                },
                new HorseDetailsViewModel
                {
                    HorseName = "Golden Dream",
                    HorseDescription = "Excellent show horse with a winning streak.",
                    HorseLocation = "Varna, Bulgaria",
                    HorseImgUrl = "URLHERE",
                    HorsePrice = 3200
                }
                

                
                
            };

    }
}
