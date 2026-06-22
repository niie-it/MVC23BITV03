using System.ComponentModel.DataAnnotations;

namespace Buoi05_Validation.Models
{
    public class UserInfo
    {
        [Display(Name ="Họ tên")]
        [MinLength(5, ErrorMessage ="Họ tên tối thiểu 5 kí tự")]
        public string FullName { get; set; }

        [Display(Name ="Tuổi")]
        [Range(16,65, ErrorMessage ="Tuổi phải từ 16 đến 65")]
        public int Age { get; set; }
    }
}
