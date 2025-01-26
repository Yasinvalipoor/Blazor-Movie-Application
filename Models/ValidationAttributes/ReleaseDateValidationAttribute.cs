using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp.Models.ValidationAttributes;

public class ReleaseDateValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value is DateTime dateValue)
        {
            var minDate = new DateTime(1980, 1, 1);
            var maxDate = new DateTime(2100, 12, 31);

            if (dateValue < minDate || dateValue > maxDate)
            {
                return new ValidationResult($"The date must be after {minDate.ToShortDateString()}");
            }
        }
        return ValidationResult.Success;
    }
}
