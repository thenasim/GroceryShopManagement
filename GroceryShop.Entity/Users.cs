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
        public string Email { get; set; }
        public string RoleId { get; set; }
        public string EmployeeId { get; set; }
        public string UpdatedAt = "GETDATE()";
    }
}
