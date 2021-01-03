namespace GroceryShop.Validation
{
    using FluentValidation;
    using GroceryShop.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            RuleFor(e => e.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name field is empty")
                .Length(2, 50).WithMessage("Name Length must be between 2 to 50")
                .Must(CustomValidations.ValidName).WithMessage("Name contains invalid characters");

            RuleFor(e => e.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Address field is empty")
                .Length(5, 50).WithMessage("Address Length must be between 5 to 50");

            RuleFor(e => e.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Phone number field is empty")
                .Length(11).WithMessage("Phone number Length must be 11 digits");

            RuleFor(e => e.Salary).NotEmpty().WithMessage("Salary can not be empty")
                .Must(CustomValidations.ValidNumber).WithMessage("{PropertyName} is not a valid number");

            RuleFor(e => e.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email field is empty")
                .EmailAddress().WithMessage("Invalid email address");

            RuleFor(e => e.BirthDate)
                .Cascade(CascadeMode.Stop)
                .Must(CustomValidations.CheckDate).WithMessage("Age is only allowed between 18 to 60");

            RuleFor(e => e.JoinDate)
                .Cascade(CascadeMode.Stop)
                .Must(CustomValidations.CheckIfDateIsFuture).WithMessage("Future date is not allowed");
        }
    }
}
