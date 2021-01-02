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

    public class CategoryRepo
    {
        public static List<Category> GetAll()
        {
            var catList = new List<Category>();
            string sql = "SELECT * FROM category";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Category categories = ConvertToEntity(dt.Rows[row]);
                catList.Add(categories);
                row++;
            }
            return catList;
        }
        private static Category ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var c = new Category();
            c.AppId = row["appid"].ToString();
            c.Name= row["name"].ToString();
            c.UpdatedAt = row["updated_at"].ToString();
            return c;
        }
        public static string GetAppId()
        {
            var sql = "SELECT TOP 1 * FROM category ORDER BY id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(1);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"ca-{id}";
            }
            return "ca-1";
        }
        public static string SaveWithName(string name)
        {
            string appId = GetAppId();
            var sql = $"INSERT INTO category VALUES('{appId}', '{name}', GETDATE())";
            var row = DataAccess.ExecuteDmlQuery(sql);
            if (row == 1)
                return appId;
            return "";
        }
        public static bool Save(Category p)
        {
            var sql = $"INSERT INTO category VALUES('{p.AppId}', '{p.Name}', {p.UpdatedAt})";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool Update(Category u)
        {
            var sql = $"update category set name = '{u.Name}', updated_at = {u.UpdatedAt} where appid = '{u.AppId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
