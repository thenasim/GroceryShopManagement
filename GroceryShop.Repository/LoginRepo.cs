namespace GroceryShop.Repository
{
    using GroceryShop.Data;
    using GroceryShop.Entity;
    using System;
    using System.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoginRepo
    {
        public static string GetAppId()
        {
            var sql = "SELECT TOP 1 * FROM logins ORDER BY id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(1);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"lg-{id}";
            }
            return "lg-1";
        }
        public static List<Logins> ShowAll()
        {
            var loginList = new List<Logins>();
            var sql = "SELECT * FROM logins;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Logins login = ConvertToEntity(dt.Rows[row]);
                loginList.Add(login);
                row++;
            }
            return loginList;
        }
        private static Logins ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var l = new Logins();
            l.AppId = row["appid"].ToString();
            l.UpdatedAt = row["updated_at"].ToString();
            l.UserId = row["user_id"].ToString();
            l.Password = row["password"].ToString();

            return l;
        }
        public static bool Save(Logins u)
        {
            var sql = $"INSERT INTO logins VALUES('{u.AppId}', '{u.Password}', '{u.UserId}', {u.UpdatedAt})";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
