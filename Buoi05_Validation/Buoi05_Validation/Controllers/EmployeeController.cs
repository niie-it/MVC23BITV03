using Buoi05_Validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Buoi05_Validation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "Employee information is valid.");
                //lưu file hoặc database
                var jsonString = JsonSerializer.Serialize(employee);
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "employee.json");
                System.IO.File.WriteAllText(fullPath, jsonString);
            }
            return View();
        }
    }
}
