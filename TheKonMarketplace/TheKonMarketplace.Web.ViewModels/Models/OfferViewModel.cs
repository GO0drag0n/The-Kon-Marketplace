using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKonMarketplace.Web.ViewModels.Models
{
    public class OfferViewModel
    {
        public string Title { get; set; } = null!;

        public string Breed { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public int OfferId { get; set; }

    }
}
