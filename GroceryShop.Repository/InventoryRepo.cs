using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GroceryShop.Data;
using GroceryShop.Entity;

namespace GroceryShop.Repository
{
    public class InventoryRepo
    {
        public DataTable SearchInventory(string key)
        {
            string sql;
            if (key == "Search here")
                sql = "select * from products;";
            else
                sql = "select * from products where title like '" + key + "%';";

            return DataAccess.GetDataTable(sql);
        }
        public DataTable ShowAll()
        {
            var sql = "select * from products;";
            return DataAccess.GetDataTable(sql);
        }
        public static void Save(Products p)
        {

        }
    }
}
