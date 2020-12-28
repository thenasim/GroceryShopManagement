namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Logins
    {
        public string AppId { get; set; }
        public string Password { get; set; }
        public int UserId { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        }
    }
}
