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
        public DataTable ShowAll()
        {
            var sql = "SELECT * FROM category;";
            return DataAccess.GetDataTable(sql);
        }
        public string GetAppId()
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
        public string SaveWithName(string name)
        {
            string appId = this.GetAppId();
            var sql = $"INSERT INTO category VALUES('{appId}', '{name}', 0, '', GETDATE())";
            var row = DataAccess.ExecuteDmlQuery(sql);
            if (row == 1)
                return appId;
            return "";
        }
        public bool Save(Category p)
        {
            var sql = $"INSERT INTO category VALUES('{p.AppId}', '{p.Name}', {p.Discount}, '', GETDATE())";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
