namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Sales
    {
        public string AppId { get; set; }
        public string Report { get; set; }
        public float TotalPrice { get; set; }
        public float Quantity { get; set; }
        public int ProductId { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        }
    }
}
