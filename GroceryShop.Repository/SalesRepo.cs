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
        public static List<Sales> ShowAll()
        {
            var salesList = new List<Sales>();
            var sql = "SELECT * FROM sales;";
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
                AppId = row["appid"].ToString(),
                Report = row["report"].ToString(),
                TotalPrice = Convert.ToDouble(row["total_price"].ToString()),
                Quantity = Convert.ToDouble(row["quantity"].ToString()),
                UpdatedAt = row["updated_at"].ToString(),
                ProductId = row["product_id"].ToString()
            };
        }

        public static bool Save(Sales u)
        {
            var sql = $"INSERT INTO sales VALUES('{u.AppId}', '{u.Report}', {u.TotalPrice}, {u.Quantity}, {u.UpdatedAt}, '{u.ProductId}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
