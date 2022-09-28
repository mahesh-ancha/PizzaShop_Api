using Microsoft.AspNetCore.Mvc;

namespace PizzaShop_Api.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
