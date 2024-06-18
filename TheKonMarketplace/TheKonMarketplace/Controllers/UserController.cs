using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TheKonMarketplace.Data.Data;
using TheKonMarketplace.Web.ViewModels.Models;
using TheKonMarketplace.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace TheKonMarketplace.Controllers
{
    public class UserController : Controller
    {
        private readonly TheKonMarketplaceDbContext data;
        private readonly UserManager<Seller> _userManager;

        public UserController(UserManager<Seller> userManager)
        {
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult BecomeSeller()
        {
            if (User.IsInRole("Seller"))
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new BecomeSellerFormModel();
            return View(model);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> BecomeSeller(BecomeSellerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = _userManager.GetUserId(User);
            var seller = await _userManager.FindByIdAsync(userId);

            if (seller == null)
            {
                return NotFound();
            }

            seller.PhoneNumber = model.PhoneNumber;

            var result = await _userManager.UpdateAsync(seller);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            await _userManager.AddToRoleAsync(seller, "Seller");
            await _userManager.RemoveFromRoleAsync(seller, "User");

            return RedirectToAction("Index", "Home");
        }

    }
}
