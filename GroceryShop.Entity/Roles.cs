﻿namespace GroceryShop.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Roles
    {
        public string AppId { get; set; }
        public string Name { get; set; }
        public bool CartAccess { get; set; }
        public bool InventoryAccess { get; set; }
        public bool UserAccess { get; set; }
        public bool ReportAccess { get; set; }
        public bool RoleAccess { get; set; }


    }
}
