using Microsoft.AspNetCore.Mvc;

namespace Buoi07_Layout.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
