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
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        }
    }
}
