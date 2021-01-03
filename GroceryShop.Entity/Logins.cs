namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Logins : CommonEntity
    {
        public string Password { get; set; }
        public string UserId { get; set; }
    }
}
