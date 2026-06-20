using Microsoft.AspNetCore.Mvc;

namespace Buoi04.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadFile(IFormFile myfile)
        {
            if (myfile != null)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", myfile.FileName);
                using (var f = new FileStream(filePath, FileMode.CreateNew))
                {
                    myfile.CopyTo(f);
                }
                TempData["Message"] = "File uploaded successfully!";
            }
            else
            {
                TempData["Message"] = "No file selected.";
            }
            return RedirectToAction("Index");
        }

        public IActionResult UploadFiles(List<IFormFile> myfiles)
        {
            if (myfiles != null && myfiles.Count > 0)
            {
                foreach (var myfile in myfiles)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "data", myfile.FileName);
                    using (var f = new FileStream(filePath, FileMode.CreateNew))
                    {
                        myfile.CopyTo(f);
                    }
                }
                TempData["Message"] = "File uploaded successfully!";
            }
            else
            {
                TempData["Message"] = "No file selected.";
            }
            return RedirectToAction("Index");
        }
    }
}
