﻿using Microsoft.AspNetCore.Mvc;

namespace PizzaShop_Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
