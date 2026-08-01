using Buoi10_MyStore.Entities;
using Buoi10_MyStore.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Buoi10_MyStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly MyeStoreContext _context;

        public AccountController(MyeStoreContext context)
        {
            _context = context;
        }

        [HttpGet("/login")]
        [AllowAnonymous]
        public IActionResult Login(string? ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost("/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginVM loginVM, string? ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            if (ModelState.IsValid)
            {
                var user = _context.KhachHangs.FirstOrDefault(u => u.MaKh == loginVM.Username && u.MatKhau == loginVM.Password);
                if (user != null)
                {
                    //khai báo claims (thông tin đặc trưng cho người dùng)
                    var claims = new List<Claim>
                    {
                        new Claim("MaKh", user.MaKh),
                        new Claim(ClaimTypes.Name, user.HoTen),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.VaiTro.ToString())
                    };

                    //tạo identity
                    var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync("MyCookieAuth", principal);

                    if (string.IsNullOrEmpty(ReturnUrl) || !Url.IsLocalUrl(ReturnUrl))
                    {
                        ReturnUrl = Url.Action("Index", "Home");
                    }

                    return Redirect(ReturnUrl);
                }
                else
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            return View();
        }

        [Authorize]
        [HttpGet("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return Redirect("/login");
        }
    }
}
