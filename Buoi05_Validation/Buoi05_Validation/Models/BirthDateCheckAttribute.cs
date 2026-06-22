using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace Buoi05_Validation.Models
{
    public class BirthDateCheckAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null) return new ValidationResult("Rỗng");
            var birthDate = (DateTime)value;
            var years = DateTime.Now.Year - birthDate.Year;
            if (years < 16 || years > 66)
            {
                return new ValidationResult("Tuổi phải lớn từ 16 - 65");
            }
            return ValidationResult.Success;
        }
    }
}