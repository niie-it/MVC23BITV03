using Buoi05_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi05_Validation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "User information is valid.");
            }
            return View();
        }
    }
}
