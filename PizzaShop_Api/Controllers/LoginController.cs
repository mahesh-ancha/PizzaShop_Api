using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Data;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class LoginController : Controller
    {
        private readonly PizzaShop_DBContext _pizzashop_DBContext1;
        public LoginController(PizzaShop_DBContext pizzaShop_DBContext)
        {
            _pizzashop_DBContext1 = pizzaShop_DBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetLogins()
        {
            var cartitem = await _pizzashop_DBContext1.Login.ToListAsync();
            return Ok(cartitem);
        }
        [HttpPost]
        public async Task<IActionResult> logging([FromBody] login loginrequest)
        {
            await _pizzashop_DBContext1.Login.AddAsync(loginrequest);
            await _pizzashop_DBContext1.SaveChangesAsync();
            return Ok(loginrequest);
        }
    }
}
