using System.ComponentModel.DataAnnotations;

namespace PizzaShop_Api.Model
{
    public class order
    {
        [Key]
        public Guid orderid { get; set; }
        public string category { get; set; }
        public string pizzaname { get; set; }
        public int price { get; set; }
    }
}
