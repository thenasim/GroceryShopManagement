namespace GroceryShop.Repository
{
    using GroceryShop.Data;
    using GroceryShop.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalesRepo
    {
        public static string GetAppId()
        {
            var sql = "SELECT TOP 1 * FROM sales ORDER BY id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(1);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"sa-{id}";
            }
            return "sa-1";
        }

        public static List<Sales> ProductSaleList(string orderByCol = "quantity")
        {
            var salesList = new List<Sales>();
            var sql = $@"SELECT TOP 5 products.title, sales.total_price, sales.quantity, sales.updated_at,
	            sales.total_price-sales.quantity*products.purchase_price AS benefit
	                FROM sales
	            INNER JOIN products ON sales.product_id = products.appid
					ORDER BY {orderByCol} DESC,
	                sales.updated_at DESC;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Sales sale = ConvertToEntity(dt.Rows[row]);
                salesList.Add(sale);
                row++;
            }
            return salesList;
        }

        private static Sales ConvertToEntity(DataRow row)
        {
            if (row == null)
                return null;

            return new Sales
            {
                TotalPrice = Convert.ToDouble(row["total_price"].ToString()),
                Quantity = Convert.ToDouble(row["quantity"].ToString()),
                Title = row["title"].ToString(),
                Benefit = row["benefit"].ToString()
            };
        }

        public static string TodaysBenefit()
        {
            var sql = @"SELECT SUM(sales.total_price-sales.quantity*products.purchase_price) AS todays_benefit
                FROM sales
                    INNER JOIN products ON sales.product_id = products.appid
                WHERE CAST(sales.updated_at AS DATE) = CAST(GETDATE() AS DATE)";
            
             var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                return Convert.ToString(data.Rows[0].Field<double>(0));
            }
            return null;
        }

        public static bool Save(Sales u)
        {
            var sql = $"INSERT INTO sales VALUES('{u.AppId}', {u.TotalPrice}, {u.Quantity}, {u.UpdatedAt}, '{u.ProductId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool DeleteByProductId(string productId)
        {
            var sql = $"DELETE FROM sales WHERE product_id = '{productId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
