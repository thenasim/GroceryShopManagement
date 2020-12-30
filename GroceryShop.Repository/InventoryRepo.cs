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
        public static DataTable SearchAppId(string key)
        {
            var sql = "select * from products where appid = '" + key + "';";
            return DataAccess.GetDataTable(sql);
        }

        public static List<Products> SearchInventory(string key)
        {
            var productList = new List<Products>();
            if (key == "Search here")
            {
                return ShowAll();
            }

            else
            {
                var sql = "select * from products where title like '" + key + "%';";
                var dt = DataAccess.GetDataTable(sql);
                int row = 0;
                while (row < dt.Rows.Count)
                {
                    Products products = ConvertToEntity(dt.Rows[row]);
                    productList.Add(products);
                    row++;
                }
                return productList;
            }
              
        }
        public static List<Products> ShowAll()
        {
            var productList = new List<Products>();
            var sql = "select * from products;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Products products = ConvertToEntity(dt.Rows[row]);
                productList.Add(products);
                row++;
            }
            return productList;
        }
        private static Products ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var p = new Products();
            p.AppId = row["appid"].ToString();
            p.Title= row["title"].ToString();
            p.Price = Convert.ToDouble(row["price"].ToString());
            p.PurchasePrice= Convert.ToDouble(row["purchase_price"].ToString());
            p.Quantity = Convert.ToDouble(row["quantity"].ToString());
            p.UpdatedAt = row["updated_at"].ToString();
            p.UserId= row["user_id"].ToString();
            p.CategoryId = row["category_id"].ToString();
            return p;

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
            var sql = $"INSERT INTO products VALUES('{p.AppId}', '{p.Title}', {p.Price}, {p.PurchasePrice}, {p.Quantity}, {p.UpdatedAt}, null, '{p.CategoryId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool Update(Products p)
        {
            var sql = "update products set title = '" + p.Title + "', price = " + p.Price + ", purchase_price = " + p.PurchasePrice + ", quantity = " + p.Quantity + " where appid = '" + p.AppId + "';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool Delete(string key)
        {
            var sql = "delete from products where appid = '" + key + "';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

    }
}
