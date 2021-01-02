namespace GroceryShop.Validation
{
    using FluentValidation;
    using GroceryShop.Entity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ProductsValidation : AbstractValidator<Products>
    {
        public ProductsValidation()
        {
            RuleFor(p => p.Title)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} is empty")
                .Length(2, 50).WithMessage("{PropertyName} length must be between 2 to 50");

            RuleFor(p => p.Price).NotEmpty().WithMessage("{PropertyName} is empty")
                .Must(ValidNumber).WithMessage("{PropertyName} is not a valid number");

            RuleFor(p => p.PurchasePrice).NotEmpty().WithMessage("{PropertyName} is empty")
                .Must(ValidNumber).WithMessage("{PropertyName} is not a valid number");

            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("{PropertyName} select or create a product category")
                .Length(3, 50).WithMessage("{PropertyName} length must be between 3 to 50");

            RuleFor(p => p.Quantity).NotEmpty().WithMessage("{PropertyName} must be greater than 0")
                .Must(ValidNumber).WithMessage("{PropertyName} is not a valid number");
        }

        private bool ValidNumber(string num)
        {
            double d;
            if (double.TryParse(num, out d) && d > 1)
                return true;
            return false;
        }
    }
}
