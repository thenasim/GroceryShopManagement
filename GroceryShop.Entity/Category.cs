using System;

namespace GroceryShop.Entity
{
    public class Category
    {
        public string AppId { get; set; }
        public string Name { get; set; }
        public float Discount { get; set; }
        public string Description { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        } 
    }
}
