using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection;
using TheKonMarketplace.Data.Data;
using TheKonMarketplace.Infrastructure;
using TheKonMarketplace.Web.ViewModels.Models;
using TheKonMarketplace.Data.Models;
using Microsoft.AspNetCore.Authorization;

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

        [HttpPost]
        [Authorize(Roles = "Seller")]
        public IActionResult Add(CreateOfferViewModel createOfferViewModel) //adding the offer
        {
            Breed? breed = _dbContext.Breeds.FirstOrDefault(x => x.Name == createOfferViewModel.Breed);

            if (breed == null)
            {
                breed = new Breed { Name = createOfferViewModel.Breed };
                _dbContext.Breeds.Add(breed);
                _dbContext.SaveChanges();
            }

            Offer offernew = new Offer
            {
                Title = createOfferViewModel.Title,
                Description = createOfferViewModel.Description,
                Price = createOfferViewModel.Price,
                BreedId = breed.Id,
                UserId = User.GetId(),
                ImageUrl = createOfferViewModel.ImageUrl,
                Location = createOfferViewModel.Location,
            };
            
            _dbContext.Offers.Add(offernew);
            _dbContext.SaveChanges();
            
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Add() //vpage visualization 
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
