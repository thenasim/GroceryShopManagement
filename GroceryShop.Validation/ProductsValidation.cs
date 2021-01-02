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
                .NotEmpty().WithMessage("Title field is empty")
                .Length(2, 50).WithMessage("Title Length must be between 2 to 50");
            RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
            RuleFor(p => p.PurchasePrice).GreaterThan(0).WithMessage("Purchase price must be greater than 0");
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Please select or create a product category");
            RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than 0");
        }
    }
}
