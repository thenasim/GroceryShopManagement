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

    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        //Minimizer button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //close buttion
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //close button hover color
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }
        //Close button hover color
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }


        //Close button hover color
        private void btnShow_MouseEnter(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.DeepSkyBlue;
            btnShow.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        //Close button hover color
        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.White;
            btnShow.FlatAppearance.BorderColor = Color.White;
        }

        //Close button hover color
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.LightGreen;
            btnSave.FlatAppearance.BorderColor = Color.LightGreen;
        }

        //Close button hover color
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
        }
    }
}
