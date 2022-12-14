using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Data;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly PizzaShop_DBContext _pizzashop_DBContext;
        public OrdersController(PizzaShop_DBContext pizzaShop_DBContext)
        {
            _pizzashop_DBContext = pizzaShop_DBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrders()
        {
            var orderitem = await _pizzashop_DBContext.order.ToListAsync();
            return Ok(orderitem);
        }
        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] order orderrequest)
        {
            await _pizzashop_DBContext.order.AddAsync(orderrequest);
            await _pizzashop_DBContext.SaveChangesAsync();
            return Ok(orderrequest);
        }
    }
}
