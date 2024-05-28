using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
using TheKonMarketplace.Data.Data;
using TheKonMarketplace.Web.ViewModels.Models;

namespace TheKonMarketplace.Controllers
{
    public class OfferController : Controller
    {
        public OfferController(TheKonMarketplaceDbContext  dbContext)
        {
            _dbContext = dbContext;
        }

        TheKonMarketplaceDbContext _dbContext;

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
    }
}
