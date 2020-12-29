using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShop.Entity
{
    public class Category
    {
        public string AppId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
        public string Description { get; set; }
        public string UpdatedAt = "GETDATE()";
    }
}
