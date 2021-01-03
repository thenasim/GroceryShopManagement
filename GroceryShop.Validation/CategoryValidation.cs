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
                .NotEmpty().WithMessage("Category is empty")
                .Length(3, 50).WithMessage("Category length must be between 3 to 50")
                .Must(CustomValidations.ValidName).WithMessage("Category contains invalid characters");
        }
    }
}
