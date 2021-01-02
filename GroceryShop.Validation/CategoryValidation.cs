namespace GroceryShop.Validation
{
    using FluentValidation;
    using GroceryShop.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(e => e.Name)
                .Cascade(CascadeMode.Stop)
                .Length(2, 50).WithMessage("Name Length must be between 2 to 50")
                .Must(ValidName).WithMessage("Name contains invalid characters");
        }
        protected bool ValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            name = name.Replace("_", "");
            return name.All(char.IsLetter);
        }
    }
}
