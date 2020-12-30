namespace GroceryShop.Repository
{
    using GroceryShop.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using GroceryShop.Entity;

    public class UserRepo
    {
        public static string GetAppId()
        {
            var sql = "SELECT TOP 1 * FROM users ORDER BY id DESC;";
            var data = DataAccess.GetDataTable(sql);
            if (data.Rows.Count == 1)
            {
                string appId = data.Rows[0].Field<string>(1);
                int id = Convert.ToInt32(appId.Split('-')[1]);
                ++id;
                return $"us-{id}";
            }
            return "us-1";
        }
        public static List<Users> ShowAll()
        {
            var userList = new List<Users>();
            var sql = "SELECT * FROM users;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Users user = ConvertToEntity(dt.Rows[row]);
                userList.Add(user);
                row++;
            }
            return userList;
        }
        private static Users ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var u = new Users();
            u.AppId = row["appid"].ToString();
            u.UpdatedAt = row["updated_at"].ToString();
            u.EmployeeId = row["employee_id"].ToString();
            u.FullName = row["full_name"].ToString();
            u.UserType = row["user_type"].ToString();

            return u;
        }
        public static bool Save(Users u)
        {
            var sql = $"INSERT INTO users VALUES('{u.AppId}', '{u.FullName}', {u.UpdatedAt}, '{u.UserType}', NULL)";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
