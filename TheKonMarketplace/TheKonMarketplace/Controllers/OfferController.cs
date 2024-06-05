using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
using TheKonMarketplace.Data.Data;
using TheKonMarketplace.Infrastructure;
using TheKonMarketplace.Web.ViewModels.Models;
using TheKonMarketplace.Data.Models;

namespace TheKonMarketplace.Controllers
{
    public class OfferController : Controller
    {
        public OfferController(TheKonMarketplaceDbContext  dbContext)
        {
            _dbContext = dbContext;
        }

        TheKonMarketplaceDbContext _dbContext;
        private readonly object data;

        [HttpGet]
        public IActionResult Add() //vpage visualization 
        {


            return View();
        }

        [HttpPost]
        public IActionResult Add(OfferViewModel model) //adding the offer
        {
            return View();
        }

        [HttpGet]
        public IActionResult Offers() //all offers visualization
        {
            List<OfferViewModel> offers = _dbContext.Offers.Select(x => new OfferViewModel{
                OfferId = x.Id,
                Title = x.Title,
                Breed = x.Breed.Name,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            
            }).ToList();



            return View(offers);
        }

        public IActionResult Mine()
        {
            //1. IOfferService - inteface public List<OfferViewModel> GetMyOffers(string userId);
            //2. OfferService - class -> dbContext -> public List<OfferViewModel> GetMyOffers(string userId)
            //3. Method in OfferService - GetMyOffers
            /*var allOffers = offerService.GetMyOffers(User.GetId(ClaimTypes.NameIdentifier));*/


            return View();
        }

    }
}
