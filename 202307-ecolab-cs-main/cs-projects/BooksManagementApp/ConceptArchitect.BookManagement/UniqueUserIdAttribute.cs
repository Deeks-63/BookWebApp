using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptArchitect.BookManagement
{
    public class UniqueUserIdAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return ValidationResult.Success;

            var userService = (IUserService)validationContext.GetService(typeof(IUserService));


            if (userService == null)
                throw new ArgumentException("User service not configured");

            try
            {
                var user = userService.GetUserById(value as string).Result;
                if (user == null)
                    return ValidationResult.Success;
                return new ValidationResult($"Duplicate Id: {value}");
            }
            catch (Exception ex)
            {

                // success
            }

            return ValidationResult.Success;
        }
    }
}
