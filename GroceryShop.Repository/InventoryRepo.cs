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
        public string GetAppId()
        {
            var sql = "SELECT TOP 1 * FROM products ORDER BY id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(1);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"pr-{id}";
            }
            return "pr-1";
        }
        public static bool Save(Products p)
        {
            var sql = $"INSERT INTO products VALUES('{p.AppId}', '{p.Title}', {p.Price}, {p.PurchasePrice}, {p.Quantity}, GETDATE(), null, '{p.CategoryId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
