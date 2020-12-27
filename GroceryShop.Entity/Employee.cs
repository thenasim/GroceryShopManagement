namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Employee
    {
        public string AppId { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public float Salary { get; set; }

    }
}
