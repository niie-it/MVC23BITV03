using Buoi10_MyStore.Entities;
using Buoi10_MyStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi10_MyStore.Controllers
{
    public class HangHoasController : Controller
    {
        private readonly MyeStoreContext _context;
        public HangHoasController(MyeStoreContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var dsHangHoas = _context.HangHoas
                .Select(hh => new HangHoaVM
                {
                    MaHh = hh.MaHh, TenHh = hh.TenHh,
                    DonGia = hh.DonGia ?? 0, Hinh = hh.Hinh,
                    SoLuong = hh.SoLanXem, //ví dụ
                    TenLoai = hh.MaLoaiNavigation.TenLoai,
                    TenNcc = hh.MaNccNavigation.TenCongTy
                }).ToList();
            return View(dsHangHoas);
            //return Json(dsHangHoas);
        }
    }
}
