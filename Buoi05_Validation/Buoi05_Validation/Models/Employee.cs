using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace Buoi05_Validation.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "EmployeeNo must be between 5 and 20 characters.")]
        public string EmployeeNo { get; set; }

        [MaxLength(100)]
        public string FullName { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string? Website { get; set; }

        [DataType(DataType.Date)]
        [BirthDateCheck]
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }

        public decimal Salary { get; set; }

        public bool IsPartTime { get; set; } = false;

        public string Address { get; set; }

        public string Phone { get; set; }
        public string CreditCard { get; set; }

        public string Description { get; set; }
    }
}
