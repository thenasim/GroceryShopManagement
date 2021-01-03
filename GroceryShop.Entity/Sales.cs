namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Sales : CommonEntity
    {
        public double TotalPrice { get; set; }
        public double Quantity { get; set; }
        public string ProductId { get; set; }
        public string Title { get; set; }
        public string Benefit { get; set; }
    }
}
