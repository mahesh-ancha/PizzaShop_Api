using Microsoft.AspNetCore.Mvc;

namespace PizzaShop_Api.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
