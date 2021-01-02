namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Users
    {
        public string AppId { get; set; }
        public string FullName { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string UpdatedAt = "GETDATE()";
    }
}
