using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TheKonMarketplace.Data.Data;
using TheKonMarketplace.Data.Models;
using TheKonMarketplace.Infrastructure;
using TheKonMarketplace.Web.ViewModels.Breed;
using TheKonMarketplace.Web.ViewModels.Models;

namespace TheKonMarketplace.Controllers
{
    public class OfferController : Controller
    {
        private readonly TheKonMarketplaceDbContext _dbContext;

        // Constructor injection for DbContext
        public OfferController(TheKonMarketplaceDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize(Roles = "Seller")]
        public IActionResult Add(CreateOfferViewModel createOfferViewModel)
        {
            // Validate the model
            if (!ModelState.IsValid)
            {
                // If the model is not valid, return the view with the model and populate the dropdown menu
                createOfferViewModel.Breeds = PopulateBreeds();
                return View(createOfferViewModel);
            }

            var offer = new Offer
            {
                Title = createOfferViewModel.Title,
                Description = createOfferViewModel.Description,
                Price = createOfferViewModel.Price,
                BreedId = createOfferViewModel.BreedId,
                UserId = User.GetId(), // Make sure GetId() is defined, possibly as an extension method on ClaimsPrincipal
                ImageUrl = createOfferViewModel.ImageUrl,
                Location = createOfferViewModel.Location,
            };

            _dbContext.Offers.Add(offer);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Add()
        {
            // 1. Create a view model for the dropdown menu
            var model = new CreateOfferViewModel
            {
                Breeds = PopulateBreeds()
            };

            // Return empty view for creating an offer
            return View(model);
        }

        [HttpGet]
        public IActionResult Offers()
        {
            var offers = _dbContext.Offers.Select(x => new OfferViewModel
            {
                OfferId = x.Id,
                Title = x.Title,
                Breed = x.Breed.Name,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            }).ToList();

            return View(offers);
        }

        [ValidateAntiForgeryToken]
        [HttpGet]
        public IActionResult Mine()
        {
            var myOffers = _dbContext.Offers
                .Where(x => x.UserId == User.GetId())
                .Select(x => new OfferViewModel
                {
                    OfferId = x.Id,
                    Title = x.Title,
                    Breed = x.Breed.Name,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl
                }).ToList();

            return View(myOffers);
        }

        [HttpPost]
        public IActionResult Delete(int offerId)
        {
            var offer = _dbContext.Offers.FirstOrDefault(x => x.Id == offerId);
            if (offer == null)
            {
                return BadRequest("Offer not found.");
            }

            _dbContext.Offers.Remove(offer);
            _dbContext.SaveChanges();
            return RedirectToAction("Mine");
        }

        public IActionResult Detail(int id)
        {
            var offer = _dbContext.Offers
                .Include(o => o.Breed)
                .Include(o => o.User) // Include the User entity to access SellerEmail and SellerPhone
                .FirstOrDefault(x => x.Id == id);

            if (offer == null)
            {
                return NotFound("Offer not found.");
            }

            var offerViewModel = new OfferViewModel
            {
                OfferId = offer.Id,
                Title = offer.Title,
                Breed = offer.Breed.Name,
                Price = offer.Price,
                ImageUrl = offer.ImageUrl,
                Description = offer.Description,
                Location = offer.Location,
                SellerEmail = offer.User.Email,
                SellerPhone = offer.User.PhoneNumber
            };

            return View(offerViewModel);
        }

        private IEnumerable<BreedViewModel> PopulateBreeds()
        {
            return _dbContext.Breeds.Select(x => new BreedViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
