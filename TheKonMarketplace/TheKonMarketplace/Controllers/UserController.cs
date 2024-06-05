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
        private readonly UserManager<Seller> userManager;

        public UserController(UserManager<Seller> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BecomeSeller()
        {
            BecomeSellerFormModel model = new BecomeSellerFormModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> BecomeSeller(BecomeSellerFormModel model)
        {
            string userId = userManager.GetUserId(User);
            Seller seller = await userManager.FindByIdAsync(userId);

            await userManager.AddToRoleAsync(seller, "Seller");
            await userManager.RemoveFromRoleAsync(seller, "User");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
