namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Products
    {
        public string AppId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public float PurchasePrice { get; set; }
        public float Quantity { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        } 
    }
}
