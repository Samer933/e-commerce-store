using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Attribiuts
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NameLengthAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string name = value as string;

            if (name != null && name.Length <= 2)
            {
                return new ValidationResult("The Name must have more than two characters.");
            }

            return ValidationResult.Success;
        }

    }
}
