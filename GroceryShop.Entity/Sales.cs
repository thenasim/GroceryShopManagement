namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sales
    {
        public string AppId { get; set; }
        public string Report { get; set; }
        public double TotalPrice { get; set; }
        public double Quantity { get; set; }
        public string ProductId { get; set; }
        public string UpdatedAt = "GETDATE()";
        public string Title { get; set; }
        public string Benefit { get; set; }
    }
}
