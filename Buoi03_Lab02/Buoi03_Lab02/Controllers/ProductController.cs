using Buoi03_Lab02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi03_Lab02.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Price = 10.0, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 2, Name = "Product B", Price = 20.0, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 3, Name = "Product C", Price = 30.0, ImageUrl = "https://via.placeholder.com/150" }
        };
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
        public IActionResult Create(Product model)
        {
            products.Add(model);//validation trước
            return RedirectToAction("Index");
        }
    }
}
