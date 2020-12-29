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

    public partial class AdminForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;
        public AdminForm()
        {
            InitializeComponent();
        }

        //close button 
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hover color for close button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        //Hover color for close button
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        //Minimize button
        private void btnMinimizeInventory_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mouse hover for log out button
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.OrangeRed;
            btnLogout.FlatAppearance.BorderColor = Color.OrangeRed;
        }

        //Mouse hover for log out button
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatAppearance.BorderColor = Color.White;
        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //Hover color of manage users button
        private void btnManageUers_MouseEnter(object sender, EventArgs e)
        {
            btnManageUers.ForeColor = Color.DeepSkyBlue;
            btnManageUers.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxManageUsers.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color of manage users button
        private void btnManageUers_MouseLeave(object sender, EventArgs e)
        {
            btnManageUers.ForeColor = Color.White;
            btnManageUers.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxManageUsers.ForeColor = Color.White;
        }

        //Hover color of sales report button
        private void btnSaleReport_MouseEnter(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.DeepSkyBlue;
            btnSaleReport.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxSalesReport.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color of sales report button
        private void btnSaleReport_MouseLeave(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.White;
            btnSaleReport.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxSalesReport.ForeColor = Color.White;
        }

        //Hover color of manage carts button
        private void btnMangeCarts_MouseEnter(object sender, EventArgs e)
        {
            btnMangeCarts.ForeColor = Color.DeepSkyBlue;
            btnMangeCarts.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxManageCart.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color of manage carts button
        private void btnMangeCarts_MouseLeave(object sender, EventArgs e)
        {
            btnMangeCarts.ForeColor = Color.White;
            btnMangeCarts.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxManageCart.ForeColor = Color.White;
        }

        //Hover color of manage inventory button
        private void btnManageInventory_MouseEnter(object sender, EventArgs e)
        {
            btnManageInventory.ForeColor = Color.DeepSkyBlue;
            btnManageInventory.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxInventory.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color of manage inventory button
        private void btnManageInventory_MouseLeave(object sender, EventArgs e)
        {
            btnManageInventory.ForeColor = Color.White;
            btnManageInventory.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxInventory.ForeColor = Color.White;
        }

        //Manage User click event
        private void btnManageUers_Click(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = true;
            pnlSalesReport.Visible = false;
            pnlManageCarts.Visible = false;
        }

        //Sales reports button click
        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            pnlSalesReport.Visible = true;
            pnlManageUsers.Visible = false;
            pnlManageCarts.Visible = false;
        }

        //Manage cart button click
        private void btnMangeCarts_Click(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = false;
            pnlSalesReport.Visible = false;
            pnlManageCarts.Visible = true;
        }

        //To hide all panel at starting
        private void pnlFeaturesButtons_Paint(object sender, PaintEventArgs e)
        {
            pnlManageUsers.Visible = false;
            pnlSalesReport.Visible = false;
            pnlManageCarts.Visible = false;

        }

       
    }
}
