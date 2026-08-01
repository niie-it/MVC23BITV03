using System.ComponentModel.DataAnnotations;

namespace Buoi10_MyStore.Models
{
    public class LoginVM
    {
        [Key]
        [MaxLength(20, ErrorMessage ="Tối đa 20 kí tự")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
