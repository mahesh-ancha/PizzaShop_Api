using Microsoft.AspNetCore.Mvc;

namespace PizzaShop_Api.Controllers
{
    public class ExploreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
