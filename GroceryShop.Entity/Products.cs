namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Products
    {
        public string AppId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double PurchasePrice { get; set; }
        public double Quantity { get; set; }
        public string UserId { get; set; }
        public string CategoryId { get; set; }
        public string UpdatedAt = "GETDATE()";
    }
}
