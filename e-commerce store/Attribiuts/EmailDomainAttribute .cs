using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce_store.Attribiuts
{
    [AttributeUsage(AttributeTargets.Property)]
    public class EmailDomainAttribute : ValidationAttribute
    {
        private readonly string[] allowedDomains;

        public EmailDomainAttribute(params string[] allowedDomains)
        {
            this.allowedDomains = allowedDomains;
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true; // Null values are handled by the Required attribute
            }

            var email = value.ToString();
            var domain = email.Split('@')[1];

            return Array.Exists(allowedDomains, d => d.Equals(domain, StringComparison.OrdinalIgnoreCase));
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} must be a valid email address with one of the following domains: {string.Join(", ", allowedDomains)}";
        }
    }
}
