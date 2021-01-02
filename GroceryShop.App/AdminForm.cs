namespace GroceryShop.App
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
        private string CurrentUserId { get; set; }
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
            Inventory iAdmin = new Inventory(this);
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
            try
            {
                var idExists = UserRepo.SearchUserId(this.CurrentUserId);
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
                        else
                        {
                            MessageBox.Show("Updating user failed");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Cann't update user\n" + error.Message);
                        this.ClearUserInput();
                    }
                    this.CurrentUserId = null;
                }
                else
                {
                    
                    try
                    {
                        if (!this.FillEntity())
                            return;
                        if (UserRepo.Save(this.User))
                        {
                            if (EmployeeRepo.Save(this.Emp))
                            {
                                if (LoginRepo.Save(this.Login))
                                {
                                    MessageBox.Show("Successfully created new user");
                                    this.PopulateGridView();
                                    this.txtAppId.Text = UserRepo.GetAppId();
                                    this.ClearUserInput();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Creating user failed");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Cann't add user\n" + error.Message);
                    }
                }
            }
            catch(Exception b)
            {
                MessageBox.Show("Error!" + b.Message);
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
            this.User = new Users();
            this.User.AppId = UserRepo.GetAppId();
            this.User.UserType = this.cboUserType.Text;
            this.User.FullName = this.txtUserName.Text;
            this.User.Password = this.txtPassword.Text;

            this.Login = new Logins();
            this.Login.AppId = LoginRepo.GetAppId();
            this.Login.Password = this.txtPassword.Text;
            this.Login.UserId = this.User.AppId;

            this.Emp = new Employee();
            this.Emp.AppId = EmployeeRepo.GetAppId();
            this.Emp.FullName = this.User.FullName;
            this.Emp.Email = null;
            this.Emp.Gender = null;
            this.Emp.Address = null;
            this.Emp.BirthDate = null;
            this.Emp.PhoneNumber = null;
            this.Emp.JoinDate = null;
            this.Emp.Salary = 0;
            this.Emp.UserId = this.User.AppId;

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
            this.User = new Users();
            this.User.AppId = this.CurrentUserId;
            this.User.Password = this.txtPassword.Text;
            this.User.UserType = this.cboUserType.Text;
            this.User.FullName = this.txtUserName.Text;

            this.Login = new Logins();
            this.Login.Password = this.txtPassword.Text;
            this.Login.UserId = this.User.AppId;

            this.Emp = new Employee();
            this.Emp.FullName = this.User.FullName;
            this.Emp.UserId = this.User.AppId;
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
            this.CurrentUserId = this.dgvUsersGrid.CurrentRow.Cells["appid"].Value.ToString();
            this.txtAppId.Text = this.CurrentUserId;
            this.txtPassword.Text = this.dgvUsersGrid.CurrentRow.Cells["password"].Value.ToString();
            this.txtUserName.Text = this.dgvUsersGrid.CurrentRow.Cells["full_name"].Value.ToString();
            this.cboUserType.Text = this.dgvUsersGrid.CurrentRow.Cells["user_type"].Value.ToString();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string appId = this.dgvUsersGrid.CurrentRow.Cells["appid"].Value.ToString();
                string name = this.dgvUsersGrid.CurrentRow.Cells["full_name"].Value.ToString();
                if (EmployeeRepo.Delete(appId))
                {
                    if (LoginRepo.Delete(appId))
                    {
                        if (UserRepo.Delete(appId))
                        {
                            MessageBox.Show(name + " has been deleted successfully");
                            this.PopulateGridView();
                            this.dgvUsersGrid.ClearSelection();
                            this.dgvUsersGrid.Refresh();
                            this.ClearUserInput();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User couldn't be deleted");
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
            catch (Exception a)
            {
                MessageBox.Show("Error!" + a.Message);
            }
            
        }

       
    }
}
