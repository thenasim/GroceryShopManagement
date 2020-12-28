namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Employee
    {
        public string AppId { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public float Salary { get; set; }
        public string UpdatedAt(string datetime = "GETDATE()")
        {
            return datetime;
        }
    }
}
