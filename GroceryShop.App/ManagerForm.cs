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

    public partial class ManagerForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;
        public ManagerForm()
        {
            InitializeComponent();
        }

        //Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Mouse hover for close button
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        //Mouse hover for close button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
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
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        //Hover color for Sales report button
        private void btnSaleReport_MouseEnter(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.DeepSkyBlue;
            btnSaleReport.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxSalesReport.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color for Sales report button
        private void btnSaleReport_MouseLeave(object sender, EventArgs e)
        {
            btnSaleReport.ForeColor = Color.White;
            btnSaleReport.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxSalesReport.ForeColor = Color.White;
        }

        //Hover color for manage salesmen button
        private void btnMangeSalesmen_MouseEnter(object sender, EventArgs e)
        {
            btnMangeEmployee.ForeColor = Color.DeepSkyBlue;
            btnMangeEmployee.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxManageSalesmen.ForeColor = Color.DeepSkyBlue;
        }

        //Hover color for manage salesmen button
        private void btnMangeSalesmen_MouseLeave(object sender, EventArgs e)
        {
            btnMangeEmployee.ForeColor = Color.White;
            btnMangeEmployee.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxManageSalesmen.ForeColor = Color.White;
        }

        //Manage Inventory button click
        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            Inventory iManager = new Inventory();
            iManager.Show();
            this.Visible = false;
        }

        //Save button hover color
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.ForestGreen;
            btnSave.FlatAppearance.BorderColor = Color.ForestGreen;
        }

        //Save button hover color
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.ForeColor = Color.White;
            btnSave.FlatAppearance.BorderColor = Color.White;
        }

        //Clear button hover color
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Red;
            btnClear.FlatAppearance.BorderColor = Color.Red;
        }

        //Clear button hover color
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.White;
        }

        //Delete Salesman button hover color
        private void btnDeleteSalesman_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteSalesman.ForeColor = Color.Red;
            btnDeleteSalesman.FlatAppearance.BorderColor = Color.Red;
        }

        //Delete salesman button hover color
        private void btnDeleteSalesman_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteSalesman.ForeColor = Color.White;
            btnDeleteSalesman.FlatAppearance.BorderColor = Color.White;
        }

        //Show users button hover color
        private void btnShowUsers_MouseEnter(object sender, EventArgs e)
        {
            btnShowEmployee.FlatAppearance.BorderColor = Color.LightBlue;
            btnShowEmployee.ForeColor = Color.LightBlue;
        }

        //Show users button hover color
        private void btnShowUsers_MouseLeave(object sender, EventArgs e)
        {
            btnShowEmployee.FlatAppearance.BorderColor = Color.White;
            btnShowEmployee.ForeColor = Color.White;
        }

        //Hide all panel visibility at the beginning
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = false;
        }

        //Ma
        private void btnMangeSalesmen_Click(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = true;
        }
    }

        
    
}
