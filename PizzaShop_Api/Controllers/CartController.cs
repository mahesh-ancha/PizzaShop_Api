using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Data;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Controllers
{
    [ApiController]
    [Route("api /[controller]")]
    public class CartController : Controller
    {
        private readonly PizzaShop_DBContext _pizzashop_DBContext;
        public CartController(PizzaShop_DBContext pizzaShop_DBContext)
        {
            _pizzashop_DBContext = pizzaShop_DBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetCartItems()
        {
            var cartitem = await _pizzashop_DBContext.Cart.ToListAsync();
            return Ok(cartitem);
        }
        [HttpPost]
        public async Task<IActionResult> AddCart([FromBody] Cart cartRequest)
        {
            await _pizzashop_DBContext.Cart.AddAsync(cartRequest);
            await _pizzashop_DBContext.SaveChangesAsync();
            return Ok(cartRequest);
        }
    }
}
