namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class CommonEntity
    {
        public string AppId { get; set; }
        public string UpdatedAt = "GETDATE()";
    }
}
