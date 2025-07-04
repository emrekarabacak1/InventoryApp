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

        [HttpGet]
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            int maxId;

            if (products.Any())
            {
                maxId = products.Max(product => product.Id);
            }
            else
            {
                maxId = 0;
            }
            product.Id = maxId + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }

    }
}