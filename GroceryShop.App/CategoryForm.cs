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
        private byte visibity;
        private byte move;
        private int moveX;
        private int moveY;
        
        private ManagerForm M1 { get; set; }
        public CategoryForm()
        {
            InitializeComponent();
        }
       
        //Manager form reference
        public CategoryForm(ManagerForm m1)
        {
            InitializeComponent();
            this.M1 = m1;
            visibity = 1;
        }

        //Minimizer button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //close buttion
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (visibity == 1)
            {
                this.Close();
                this.M1.Visible = true;
            }
            else
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
            btnEdit.ForeColor = Color.LightGreen;
            btnEdit.FlatAppearance.BorderColor = Color.LightGreen;
        }

        //Close button hover color
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatAppearance.BorderColor = Color.White;
        }

        //Move the form
        private void pnlFormmove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //Move the form
        private void pnlFormmove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //Move the form
        private void pnlFormmove_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
