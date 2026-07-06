using System.ComponentModel.DataAnnotations;

namespace Buoi10_MyStore.Models
{
    public class HangHoaVM
    {
        [Key]
        public int MaHh { get; set; }
        public string TenHh { get; set; } = null!;
        public string Hinh { get; set; } = null!;
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string TenLoai { get; set; }
        public string TenNcc { get; set; }
        public bool SapChayHang => SoLuong < 5;
    }
}
