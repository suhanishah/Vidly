using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Min18YearIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //refering customer and casting it t object Customer
            var customer = (Customer)validationContext.ObjectInstance;
            
            //checking various scenarios

            if(customer.MembershipTypeId == MembershipType.Unkown ||customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Member has to be 18 years or older");

        }
    }
}