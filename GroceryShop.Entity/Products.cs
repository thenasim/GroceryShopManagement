﻿namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Products : CommonEntity
    {
        public string Title { get; set; }
        public string Price { get; set; }
        public string PurchasePrice { get; set; }
        public string Quantity { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
