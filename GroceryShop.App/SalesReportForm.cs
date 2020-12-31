namespace GroceryShop.App
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }
        //Minimize work
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // form close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //close button hover
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }
        //close button hover
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        //Clear button hover color
        private void btnClearSalesReport_MouseEnter(object sender, EventArgs e)
        {
            btnClearSalesReport.ForeColor = Color.Red;
            btnClearSalesReport.FlatAppearance.BorderColor = Color.Red;
        }

        //Clear button hover color
        private void btnClearSalesReport_MouseLeave(object sender, EventArgs e)
        {
            btnClearSalesReport.ForeColor = Color.White;
            btnClearSalesReport.FlatAppearance.BorderColor = Color.White;
        }
    }
}
