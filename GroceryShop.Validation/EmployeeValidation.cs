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
                .Must(ValidName).WithMessage("Name contains invalid characters");

            RuleFor(e => e.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Address field is empty")
                .Length(5, 50).WithMessage("Address Length must be between 5 to 50");

            RuleFor(e => e.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Phone number field is empty")
                .Length(11).WithMessage("Phone number Length must be 11 digits");

            RuleFor(e => e.Salary).NotEmpty().WithMessage("Salary can not be empty")
                .Must(ValidNumber).WithMessage("{PropertyName} is not a valid number");

            RuleFor(e => e.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email field is empty")
                .EmailAddress().WithMessage("Invalid email address");
        }

        protected bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }

        private bool ValidNumber(string num)
        {
            double d;
            if (double.TryParse(num, out d) && d > 0)
                return true;
            return false;
        }
    }
}
