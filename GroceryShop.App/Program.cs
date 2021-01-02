using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShop.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new Inventory());
            //Application.Run(new Userdetails());
            //Application.Run(new AdminForm());
            //Application.Run(new SalesmanForm());
            //Application.Run(new ManagerForm());
            //Application.Run(new AdminForm());
            //Application.Run(new SalesmanForm());
            Application.Run(new ManagerForm());
            //Application.Run(new SalesReportForm());
            //Application.Run(new CategoryForm());
        }
    }
}
