using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryShop.App
{
    
    public partial class LoginForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;

        public LoginForm()
        {
            InitializeComponent();
        }

        //To close log in form
        private void btnCloseLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeLogIn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Hover color when mouse enters for login button
        private void btnLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.DeepSkyBlue;
            btnLogIn.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        //Hover color when mouse leaves for login button
        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnLogIn.ForeColor = Color.White;
            btnLogIn.FlatAppearance.BorderColor = Color.White;
        }

        //Hover color when mouse neters for login form close button
        private void btnCloseLogIn_MouseEnter(object sender, EventArgs e)
        {
            btnCloseLogIn.ForeColor = Color.Red;
        }
        //Hover color when mouse leaves for login form close button
        private void btnCloseLogIn_MouseLeave(object sender, EventArgs e)
        {
            btnCloseLogIn.ForeColor = Color.White;
        }
        //LogIn button 
        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        // enters username textbox
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.White;
            }
        }

        //leave username textbox
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        //leave password textbox
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        //Enter password textbox
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
            }
        }

        //To move the form all over the screen
        private void pnlToMoveTheForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y- moveY);
            }
        }

        //To move the form all over the screen
        private void pnlToMoveTheForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //To move the form all over the screen
        private void pnlToMoveTheForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
    }
}
