namespace GroceryShop.Validation
{
    using FluentValidation;
    using GroceryShop.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserValidation : AbstractValidator<Users>
    {
        public UserValidation()
        {
            RuleFor(u => u.Password).NotEmpty().Length(6, 20).WithMessage("Password Length must be between 6 to 20");

            RuleFor(u => u.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name field is empty")
                .Length(2, 50).WithMessage("Name Length must be between 2 to 50")
                .Must(ValidName).WithMessage("Name contains invalid characters");

            RuleFor(u => u.UserType).NotEmpty().WithMessage("Seletct a user type");

        }
        protected bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(char.IsLetter);
        }
    }
}
