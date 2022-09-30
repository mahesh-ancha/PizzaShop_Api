using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaShop_Api.Data;
using PizzaShop_Api.Model;

namespace PizzaShop_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : Controller
    {
        private readonly PizzaShop_DBContext _pizzashop_DBContext;
        public ReviewsController(PizzaShop_DBContext pizzaShop_DBContext)
        {
            _pizzashop_DBContext = pizzaShop_DBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetReviews()
        {
            var reviewitem = await _pizzashop_DBContext.reviews.ToListAsync();
            return Ok(reviewitem);
        }
        [HttpPost]
        public async Task<IActionResult> AddReview([FromBody] reviews reviewrequest)
        {
            await _pizzashop_DBContext.reviews.AddAsync(reviewrequest);
            await _pizzashop_DBContext.SaveChangesAsync();
            return Ok(reviewrequest);
        }
    }
}
