namespace GroceryShop.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GroceryShop.Data;
    using GroceryShop.Entity;

    public class EmployeeRepo
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
                return $"em-{id}";
            }
            return "em-1";
        }
        public static List<Employee> ShowAll()
        {
            var employeeList = new List<Employee>();
            var sql = "SELECT * FROM employee;";
            var dt = DataAccess.GetDataTable(sql);
            int row = 0;
            while (row < dt.Rows.Count)
            {
                Employee employee = ConvertToEntity(dt.Rows[row]);
                employeeList.Add(employee);
                row++;
            }
            return employeeList;
        }
        private static Employee ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var emp = new Employee();
            emp.AppId = row["appid"].ToString();
            emp.FullName = row["full_name"].ToString();
            emp.Email = row["email"].ToString();
            emp.Gender = row["gender"].ToString();
            emp.Address = row["address"].ToString();
            emp.BirthDate = row["birthdate"].ToString();
            emp.PhoneNumber = row["phone"].ToString();
            emp.JoinDate = row["join_date"].ToString();
            emp.Salary = row["salary"].ToString();
            emp.UserId = row["user_id"].ToString();
            emp.UpdatedAt = row["updated_at"].ToString();
            return emp;
        }
        public static bool Save(Employee e)
        {
            var sql = $"INSERT INTO employee VALUES('{e.AppId}', '{e.FullName}', '{e.Email}', '{e.Gender}', '{e.Address}', '{e.BirthDate}', '{e.PhoneNumber}', '{e.JoinDate}', '{e.Salary}', '{e.UserId}', {e.UpdatedAt})";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool Update(Employee u)
        {
            var sql = $"update employee set email = '{u.Email}', full_name = '{u.FullName}', gender = '{u.Gender}', address = '{u.Address}', birthdate = '{u.BirthDate}', phone = '{u.PhoneNumber}', join_date = '{u.JoinDate}', salary = {u.Salary}, updated_at = {u.UpdatedAt} where user_id = '{u.UserId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static bool UpdateWithName(Employee u)
        {
            var sql = $"update employee set full_name = '{u.FullName}', updated_at = {u.UpdatedAt} where user_id = '{u.UserId}';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }

        public static bool Delete(string key)
        {
            var sql = "delete from employee where user_id = '" + key + "';";
            var row = DataAccess.ExecuteDmlQuery(sql);
            return row == 1;
        }
        public static List<Employee> SearchEmployee(string key)
        {
            var employeeList = new List<Employee>();
            if (key == "Search here")
            {
                return ShowAll();
            }

            else
            {
                var sql = @"SELECT * from employee WHERE user_id like '" + key + "%';";
                var dt = DataAccess.GetDataTable(sql);
                int row = 0;
                while (row < dt.Rows.Count)
                {
                    Employee emp = ConvertToEntity(dt.Rows[row]);
                    employeeList.Add(emp);
                    row++;
                }
                return employeeList;
            }

        }
    }
}
