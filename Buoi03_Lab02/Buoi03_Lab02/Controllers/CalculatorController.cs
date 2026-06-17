using Microsoft.AspNetCore.Mvc;

namespace Buoi03_Lab02.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculate(double SoHang01, int SoHang02, string ToanTu)
        {
            double KetQua = 0;
            switch (ToanTu)
            {
                case "%": KetQua = SoHang01 % SoHang02; break;
                case "^": KetQua = Math.Pow(SoHang01, SoHang02); break;
                case "+": KetQua = SoHang01 + SoHang02; break;
                case "-": KetQua = SoHang01 - SoHang02; break;
                case "*": KetQua = SoHang01 * SoHang02; break;
                case "/":
                    if (SoHang02 != 0)
                        KetQua = SoHang01 / SoHang02;
                    else
                        ViewBag.ErrorMessage = "Không thể chia cho 0!";
                    break;
                default:
                    ViewBag.ErrorMessage = "Phép toán không hợp lệ!";
                    break;
            }
            ViewBag.KetQua = KetQua;
            ViewBag.SoHang01 = SoHang01;
            ViewBag.SoHang02 = SoHang02;
            ViewBag.ToanTu = ToanTu;
            return View("Index");
        }
    }
}
