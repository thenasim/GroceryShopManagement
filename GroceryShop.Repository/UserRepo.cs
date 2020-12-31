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
        public static List<Users> SearchUser(string key)
        {
            var userList = new List<Users>();
            if (key == "Search here")
            {
                return ShowAll();
            }

            else
            {
                var sql = @"SELECT users.appid, users.full_name, users.user_type,
                       logins.password FROM users INNER JOIN logins 
                        ON users.appid = logins.user_id WHERE users.full_name like '" + key + "%';";
                var dt = DataAccess.GetDataTable(sql);
                int row = 0;
                while (row < dt.Rows.Count)
                {
                    Users users = ConvertToEntity(dt.Rows[row]);
                    userList.Add(users);
                    row++;
                }
                return userList;
            }

        }
        public static List<Users> ShowAll()
        {
            var userList = new List<Users>();
            var sql = @"SELECT users.appid, users.full_name, users.user_type,
                       logins.password FROM users INNER JOIN logins 
                        ON users.appid = logins.user_id;";
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
            u.FullName = row["full_name"].ToString();
            u.UserType = row["user_type"].ToString();
            u.Password = row["password"].ToString();

            return u;
        }
        public static bool Save(Users u)
        {
            var sql = $"INSERT INTO users VALUES('{u.AppId}', '{u.FullName}', {u.UpdatedAt}, '{u.UserType}')";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool Update(Users p)
        {
            var sql = $"update users set full_name = '{p.FullName}', user_type = '{p.UserType}', updated_at = {p.UpdatedAt} where appid = '{p.AppId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool SearchUserId(string key)
        {
            var sql = "select * from users where appid = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            return dt.Rows.Count == 1;
        }
        public static string GetUserType(string key)
        {
            var sql = "select user_type from users where appid = '" + key + "';";
            var dt = DataAccess.GetDataTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                return (row["user_type"].ToString());
            }
            return null;
        }
        public static bool Delete(string key)
        {
            var sql = "delete from users where appid = '" + key + "';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
    }
}
