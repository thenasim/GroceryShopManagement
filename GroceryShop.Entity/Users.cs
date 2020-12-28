namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Users
    {
        public string AppId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int EmployeeId { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        }
    }
}
