using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Buoi08_EFCoreCodeFirst.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { get; set; }
        [MaxLength(50)]
        public string TenLoai { get; set; }
        public string? MoTa { get; set; }
        [MaxLength(150)]
        public string? Hinh { get; set; }

        public ICollection<HangHoa> HangHoas { get; set; } = new List<HangHoa>();
    }

    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHH { get; set; }

        [MaxLength(50)]
        public string TenHH { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string Hinh { get; set; }
        public int? MaLoai { get; set; }

        [ForeignKey("MaLoai")]
        public Loai? Loai { get; set; }
    }
}
