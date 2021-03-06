﻿namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public sealed class Employee : CommonEntity
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string JoinDate { get; set; }
        public string Salary { get; set; }
        public string UserId { get; set; }
    }
}
