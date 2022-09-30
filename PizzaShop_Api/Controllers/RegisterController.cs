using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Data;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class RegisterController : Controller
    {

        private readonly PizzaShop_DBContext _pizzashop_DBContext1;
        public RegisterController(PizzaShop_DBContext pizzaShop_DBContext)
        {
            _pizzashop_DBContext1 = pizzaShop_DBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetRegisters()
        {
            var cartitem = await _pizzashop_DBContext1.register.ToListAsync();
            return Ok(cartitem);
        }
        [HttpPost]
        public async Task<IActionResult> registers([FromBody] register registerrequest)
        {
            await _pizzashop_DBContext1.register.AddAsync(registerrequest);
            await _pizzashop_DBContext1.SaveChangesAsync();
            return Ok(registerrequest);
        }
    }
}
