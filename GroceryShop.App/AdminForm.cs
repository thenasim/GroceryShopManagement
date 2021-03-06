﻿namespace GroceryShop.App
{
    using GroceryShop.Entity;
    using GroceryShop.Repository;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using GroceryShop.Validation;
    using FluentValidation.Results;

    public partial class AdminForm : Form
    {
        private Users User { get; set; }
        private Logins Login { get; set; }
        private Employee Emp { get; set; }
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
            this.PopulateGridView();
            this.txtAppId.Text = UserRepo.GetAppId();   
        }

        //Sales reports button click
        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            SalesReportForm sAdmin = new SalesReportForm(this);
            sAdmin.Show();
            this.Visible = false;          
        }

        //Manage cart button click
        private void btnMangeCarts_Click(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = false;
            pnlSalesReport.Visible = false;
           
        }

        //To hide all panel at starting
        private void pnlFeaturesButtons_Paint(object sender, PaintEventArgs e)
        {
            pnlManageUsers.Visible = false;
            pnlSalesReport.Visible = false;
           

        }

        //Hover color for user management add button
        private void btnUserAdd_MouseEnter(object sender, EventArgs e)
        {
            btnUserAdd.ForeColor = Color.LightGreen;
            btnUserAdd.FlatAppearance.BorderColor = Color.LightGreen;
        }

        //Hover color for user management add button
        private void btnUserAdd_MouseLeave(object sender, EventArgs e)
        {
            btnUserAdd.ForeColor = Color.White;
            btnUserAdd.FlatAppearance.BorderColor = Color.White;
        }

        //Hover color for user management clear button
        private void btnClearUser_MouseEnter(object sender, EventArgs e)
        {
            btnClearUser.ForeColor = Color.IndianRed;
            btnClearUser.FlatAppearance.BorderColor = Color.IndianRed;
        }

        //Hover color for user management clear button
        private void btnClearUser_MouseLeave(object sender, EventArgs e)
        {
            btnClearUser.ForeColor = Color.White;
            btnClearUser.FlatAppearance.BorderColor = Color.White;
        }

        //Hover color for show users
        private void btnShowUsers_MouseEnter(object sender, EventArgs e)
        {
            btnShowUsers.ForeColor = Color.LightBlue;
            btnShowUsers.FlatAppearance.BorderColor = Color.LightBlue;
        }

        //Hover color for show users
        private void btnShowUsers_MouseLeave(object sender, EventArgs e)
        {
            btnShowUsers.ForeColor = Color.White;
            btnShowUsers.FlatAppearance.BorderColor = Color.White;
        }

        //Hover color for delete user button
        private void btnDeleteUser_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteUser.ForeColor = Color.Red;
            btnDeleteUser.FlatAppearance.BorderColor = Color.Red;
        }

        //Hover color for delete user button
        private void btnDeleteUser_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.FlatAppearance.BorderColor = Color.White;
        }
        //Hover color for search button
        private void btnSearchInventory_MouseEnter(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.SkyBlue;
        }

        //Hover color for search button
        private void btnSearchInventory_Leave(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.White;
        }

        //Search bar water mark
        private void txtSearchbar_Enter(object sender, EventArgs e)
        {
            if (txtSearchbar.Text == "Search here")
            {
                txtSearchbar.Text = "";
                txtSearchbar.ForeColor = Color.White;
            }
        }

        //Search bar watar mark
        private void txtSearchbar_Leave(object sender, EventArgs e)
        {
            if (txtSearchbar.Text == "")
            {
                txtSearchbar.Text = "Search here";
                txtSearchbar.ForeColor = Color.Gray;
            }
        }

        //Sales report clear button hover color
        private void btnClearSalesReport_MouseEnter(object sender, EventArgs e)
        {
            btnClearSalesReport.ForeColor = Color.Red;
            btnClearSalesReport.FlatAppearance.BorderColor = Color.Red;
        }

        //Sales report clear button hover color
        private void btnClearSalesReport_MouseLeave(object sender, EventArgs e)
        {
            btnClearSalesReport.ForeColor = Color.White;
            btnClearSalesReport.FlatAppearance.BorderColor = Color.White;
        }

        //Manage inventory button 
        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            InventoryForm iAdmin = new InventoryForm(this);
            iAdmin.Show();
            this.Visible = false;
        }
        //Log out button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            LoginForm lAdmin = new LoginForm();
            lAdmin.Show();
            this.Visible = false;
        }


        /*
         backend code
         */
        private void PopulateGridView()
        {
            try
            {
                this.dgvUsersGrid.AutoGenerateColumns = false;
                this.dgvUsersGrid.DataSource = UserRepo.ShowAll();
                this.dgvUsersGrid.ClearSelection();
                this.dgvUsersGrid.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }
            
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {

            var idExists = UserRepo.SearchUserId(this.txtAppId.Text);
            if (idExists)
            {

                try
                {
                    if (!this.UpdateFillEntity())
                        return;
                    if (UserRepo.Update(this.User) && LoginRepo.Update(this.Login) && EmployeeRepo.UpdateWithName(this.Emp))
                    {
                        MessageBox.Show("Successfully updated  user");
                        this.PopulateGridView();
                        this.txtAppId.Text = UserRepo.GetAppId();
                        this.ClearUserInput();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cann't update user\n" + error.Message);
                    this.ClearUserInput();
                }
            }
            else
            {
                if (this.cboUserType.Text == "Admin")
                {
                    MessageBox.Show("Can not create a new admin");
                    return;
                }
                try
                {
                    if (!this.FillEntity())
                        return;
                    if (UserRepo.Save(this.User) && EmployeeRepo.Save(this.Emp) && LoginRepo.Save(this.Login))
                    {
                        MessageBox.Show("Successfully created new user");
                        this.PopulateGridView();
                        this.txtAppId.Text = UserRepo.GetAppId();
                        this.ClearUserInput();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cann't add user\n" + error.Message);
                }
            }
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            this.ClearUserInput();
            txtSearchbar.Text = "Search here";
            txtSearchbar.ForeColor = Color.Gray;
            this.dgvUsersGrid.DataSource = null;
        }

        private void ClearUserInput()
        {
            try
            {
                this.txtAppId.Text = UserRepo.GetAppId();
                this.txtPassword.Text = "";
                this.txtUserName.Text = "";
                this.cboUserType.SelectedIndex = -1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }
            
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private bool FillEntity()
        {
            this.User = new Users
            {
                AppId = UserRepo.GetAppId(),
                UserType = this.cboUserType.Text,
                FullName = this.txtUserName.Text,
                Password = this.txtPassword.Text
            };

            this.Login = new Logins
            {
                AppId = LoginRepo.GetAppId(),
                Password = this.txtPassword.Text,
                UserId = this.User.AppId
            };

            this.Emp = new Employee
            {
                AppId = EmployeeRepo.GetAppId(),
                FullName = this.User.FullName,
                Email = null,
                Gender = null,
                Address = null,
                BirthDate = null,
                PhoneNumber = null,
                JoinDate = null,
                Salary = "",
                UserId = this.User.AppId
            };

            UserValidation validator = new UserValidation();
            ValidationResult results = validator.Validate(this.User);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }


        private bool UpdateFillEntity()
        {
            this.User = new Users
            {
                AppId = this.txtAppId.Text,
                Password = this.txtPassword.Text,
                UserType = this.cboUserType.Text,
                FullName = this.txtUserName.Text
            };

            this.Login = new Logins
            {
                Password = this.txtPassword.Text,
                UserId = this.User.AppId
            };

            this.Emp = new Employee
            {
                FullName = this.User.FullName,
                UserId = this.User.AppId
            };

            UserValidation validator = new UserValidation();
            ValidationResult results = validator.Validate(this.User);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }

        private void dgvUsersGrid_DoubleClick(object sender, EventArgs e)
        {
            this.txtAppId.Text = this.dgvUsersGrid.CurrentRow.Cells["appid"].Value.ToString();
            this.txtPassword.Text = this.dgvUsersGrid.CurrentRow.Cells["password"].Value.ToString();
            this.txtUserName.Text = this.dgvUsersGrid.CurrentRow.Cells["full_name"].Value.ToString();
            this.cboUserType.Text = this.dgvUsersGrid.CurrentRow.Cells["user_type"].Value.ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string userType = this.dgvUsersGrid.CurrentRow.Cells["user_type"].Value.ToString();
            if (userType == "Admin")
            {
                MessageBox.Show("Can not delete admin");
                return;
            }

            if (this.dgvUsersGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected");
                return;
            }

            string appId = this.dgvUsersGrid.CurrentRow.Cells["appid"].Value.ToString();
            string name = this.dgvUsersGrid.CurrentRow.Cells["full_name"].Value.ToString();

            if (MessageBox.Show($"Do you want to delete {name}?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            try
            {
                if (EmployeeRepo.Delete(appId) && LoginRepo.Delete(appId) && UserRepo.Delete(appId))
                {
                    MessageBox.Show(name + " has been deleted successfully");
                    this.PopulateGridView();
                    this.dgvUsersGrid.ClearSelection();
                    this.dgvUsersGrid.Refresh();
                    this.ClearUserInput();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error!" + a.Message);
            }
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            try
            {
                this.dgvUsersGrid.AutoGenerateColumns = false;
                this.dgvUsersGrid.DataSource = UserRepo.SearchUser(this.txtSearchbar.Text);
                this.dgvUsersGrid.ClearSelection();
                this.dgvUsersGrid.Refresh();
                if (this.dgvUsersGrid.RowCount == 0)
                {
                    MessageBox.Show("No Data Found!");
                }
            }
            catch
            {
                MessageBox.Show("Please insert a valid keyword");
            }
        }
    }
}
