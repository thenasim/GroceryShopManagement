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
    using GroceryShop.Entity;
    using GroceryShop.Repository;

    public partial class ManagerForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;
        private Employee Emp { get; set; }
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
            Inventory iManager = new Inventory(this);
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

        //Manage invenotry button hover color
        private void btnManageInventory_MouseEnter(object sender, EventArgs e)
        {
            btnManageInventory.ForeColor = Color.DeepSkyBlue;
            btnManageInventory.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            iconPictureBoxInventory.ForeColor = Color.DeepSkyBlue;
        }

        //Manage invenotry button hover color
        private void btnManageInventory_MouseLeave(object sender, EventArgs e)
        {
            btnManageInventory.ForeColor = Color.White;
            btnManageInventory.FlatAppearance.BorderColor = Color.White;
            iconPictureBoxInventory.ForeColor = Color.White;
        }

        //Category  button hover color
        private void btnCategory_MouseEnter(object sender, EventArgs e)
        {
            btnCategory.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btnCategory.ForeColor = Color.DeepSkyBlue;
            iconPictureBoxCategory.ForeColor = Color.DeepSkyBlue;

        }

        //Category button hover color
        private void btnCategory_MouseLeave(object sender, EventArgs e)
        {
            btnCategory.FlatAppearance.BorderColor = Color.White;
            btnCategory.ForeColor = Color.White;
            iconPictureBoxCategory.ForeColor = Color.White;
        }

        //Sales Report button click
        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            SalesReportForm sManager = new SalesReportForm(this);
            sManager.Show();
            this.Visible = false;
        }

        //Category button click
        private void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryForm cManager = new CategoryForm(this);
            cManager.Show();
            this.Visible = false;
        }
        //Search button hover color
        private void btnSearchInventory_MouseEnter(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.SkyBlue;
        }

        //Search button hover color
        private void btnSearchInventory_MouseLeave(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.White;
        }

        //Log out button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LoginForm lManager = new LoginForm();
            lManager.Show();
        }

        //Ma
        private void btnMangeSalesmen_Click(object sender, EventArgs e)
        {
            pnlManageUsers.Visible = true;
            this.PopulateGridView();
        }

        private void PopulateGridView()
        {
            this.dgvSalesmen.AutoGenerateColumns = false;
            this.dgvSalesmen.DataSource = EmployeeRepo.ShowAll();
            this.dgvSalesmen.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.UpdateFillEntity();
            try
            {
                if (EmployeeRepo.Update(this.Emp))
                {
                    MessageBox.Show("Successfully updated  user");
                    this.PopulateGridView();
                    this.ClearInput();

                }
                else
                {
                    MessageBox.Show("Updating employee failed");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Can not update employee\n" + error.Message);
                this.ClearInput();
            }

        }
        private void UpdateFillEntity()
        {
            this.Emp = new Employee();
            this.Emp.Email = this.txtEmail.Text;
            this.Emp.FullName = this.txtEmpName.Text;
            this.Emp.Gender = this.cmbGender.Text;
            this.Emp.Address = this.txtAddress.Text;
            this.Emp.BirthDate = this.dtpBirthdate.Text;
            this.Emp.PhoneNumber = this.txtPhonenumber.Text;
            this.Emp.JoinDate = this.dtpJoindate.Text;
            this.Emp.Salary = Convert.ToDouble(this.txtSalary.Text);
            this.Emp.UserId = this.txtUserId.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearInput();
            txtSearchbar.Text = "Search here";
            txtSearchbar.ForeColor = Color.Gray;
            this.dgvSalesmen.DataSource = null;
        }
        private void ClearInput()
        {
            this.txtUserId.Text = "";
            this.txtEmpName.Text = "";
            this.txtEmail.Text = "";
            this.txtAddress.Text = "";
            this.cmbGender.Text = "";
            this.dtpBirthdate.Text = "";
            this.txtSalary.Text = "";
            this.txtPhonenumber.Text = "";
            this.dtpJoindate.Text = "";
        }

        private void btnShowEmployee_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void dgvSalesmen_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvSalesmen.CurrentRow.Cells["user_id"].Value.ToString();
            this.txtEmpName.Text = this.dgvSalesmen.CurrentRow.Cells["full_name"].Value.ToString();
            this.txtEmail.Text = this.dgvSalesmen.CurrentRow.Cells["email"].Value.ToString();
            this.txtAddress.Text = this.dgvSalesmen.CurrentRow.Cells["address"].Value.ToString();
            this.cmbGender.Text = this.dgvSalesmen.CurrentRow.Cells["gender"].Value.ToString();
            this.dtpBirthdate.Text = this.dgvSalesmen.CurrentRow.Cells["birthdate"].Value.ToString();
            this.txtSalary.Text = this.dgvSalesmen.CurrentRow.Cells["salary"].Value.ToString();
            this.txtPhonenumber.Text = this.dgvSalesmen.CurrentRow.Cells["phone"].Value.ToString();
            this.dtpJoindate.Text = this.dgvSalesmen.CurrentRow.Cells["join_date"].Value.ToString();
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            this.dgvSalesmen.AutoGenerateColumns = false;
            this.dgvSalesmen.DataSource = EmployeeRepo.SearchEmployee(this.txtSearchbar.Text);
            this.dgvSalesmen.ClearSelection();
            this.dgvSalesmen.Refresh();
            if (this.dgvSalesmen.RowCount == 0)
            {
                MessageBox.Show("No Data Found!");
            }
        }

        
    }

        
    
}
