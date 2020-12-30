﻿namespace GroceryShop.App
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

    public partial class EmployeeForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        //form close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Close Button hover color
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        //Close Button hover color
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

        //To move the form all over the screen
        private void pnlToMoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        //Hover color for manage carts button
        private void btnMangeCarts_MouseEnter(object sender, EventArgs e)
        {
            btnMangeCarts.ForeColor = Color.DeepSkyBlue;
            btnMangeCarts.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxManageCart.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color for manage carts button
        private void btnMangeCarts_MouseLeave(object sender, EventArgs e)
        {
            btnMangeCarts.ForeColor = Color.White;
            btnMangeCarts.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxManageCart.ForeColor = Color.White;
        }

        //Hover color for sales report button
        private void btnSaleReport_MouseEnter(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.DeepSkyBlue;
            btnSaleReport.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxSalesReport.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color for sales report button
        private void btnSaleReport_MouseLeave(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.White;
            btnSaleReport.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxSalesReport.ForeColor = Color.White;
        }

        //To hide all visibility of all features panels at starting
        private void pnlEmployeeform_Paint(object sender, PaintEventArgs e)
        {
            pnlManageCarts.Visible = false;
        }

        //Manage cart button
        private void btnMangeCarts_Click(object sender, EventArgs e)
        {
            pnlManageCarts.Visible = true;
        }
    }
}
