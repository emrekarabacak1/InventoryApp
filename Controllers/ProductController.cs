using Microsoft.AspNetCore.Mvc;
using InventoryApp.Models;


namespace InventoryApp.Controllers
{
    public class ProductController : Controller
    {

        private static List<Product> products = new List<Product>()
        {
            new Product{Id=1, Name="Laptop",Price=45000},
            new Product{Id=2, Name="Mouse",Price=500},
            new Product{Id=3, Name="Keyboard",Price=1000},
            new Product{Id=4, Name="Monitor",Price=5000},
        };

        public IActionResult Index()
        {
            return View(products);
        }

    }
}