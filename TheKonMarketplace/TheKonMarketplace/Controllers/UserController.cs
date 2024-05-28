using Microsoft.AspNetCore.Mvc;

namespace TheKonMarketplace.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BecomeSeller()
        {
            return View();
        }
    }
}
