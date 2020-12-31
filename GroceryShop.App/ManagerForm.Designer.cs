namespace GroceryShop.App
{

    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.pnlToMoveForm = new System.Windows.Forms.Panel();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.iconPictureBoxSalesReport = new FontAwesome.Sharp.IconPictureBox();
            this.btnMangeEmployee = new System.Windows.Forms.Button();
            this.iconPictureBoxManageSalesmen = new FontAwesome.Sharp.IconPictureBox();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.iconPictureBoxInventory = new FontAwesome.Sharp.IconPictureBox();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.pnlAdduser = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.dtpJoindate = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.pnlGridviewAllusers = new System.Windows.Forms.Panel();
            this.dgvSalesmen = new System.Windows.Forms.DataGridView();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.lblManageEmployee = new System.Windows.Forms.Label();
            this.iconPictureBoxSalesmen = new FontAwesome.Sharp.IconPictureBox();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.join_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToMoveForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageSalesmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInventory)).BeginInit();
            this.pnlManageUsers.SuspendLayout();
            this.pnlAdduser.SuspendLayout();
            this.pnlGridviewAllusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToMoveForm
            // 
            this.pnlToMoveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlToMoveForm.Controls.Add(this.btnSearchInventory);
            this.pnlToMoveForm.Controls.Add(this.txtSearchbar);
            this.pnlToMoveForm.Controls.Add(this.btnMinimizeInventory);
            this.pnlToMoveForm.Controls.Add(this.btnClose);
            this.pnlToMoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToMoveForm.Location = new System.Drawing.Point(0, 0);
            this.pnlToMoveForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlToMoveForm.Name = "pnlToMoveForm";
            this.pnlToMoveForm.Size = new System.Drawing.Size(1533, 50);
            this.pnlToMoveForm.TabIndex = 0;
            this.pnlToMoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveForm_MouseDown);
            this.pnlToMoveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveForm_MouseMove);
            this.pnlToMoveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveForm_MouseUp);
            // 
            // btnSearchInventory
            // 
            this.btnSearchInventory.FlatAppearance.BorderSize = 0;
            this.btnSearchInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnSearchInventory.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearchInventory.IconColor = System.Drawing.Color.White;
            this.btnSearchInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchInventory.IconSize = 27;
            this.btnSearchInventory.Location = new System.Drawing.Point(1027, 9);
            this.btnSearchInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(37, 33);
            this.btnSearchInventory.TabIndex = 7;
            this.btnSearchInventory.UseVisualStyleBackColor = true;
            this.btnSearchInventory.Click += new System.EventHandler(this.btnSearchInventory_Click);
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtSearchbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbar.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchbar.Location = new System.Drawing.Point(471, 10);
            this.txtSearchbar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(551, 27);
            this.txtSearchbar.TabIndex = 6;
            this.txtSearchbar.Text = "Search here";
            // 
            // btnMinimizeInventory
            // 
            this.btnMinimizeInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnMinimizeInventory.FlatAppearance.BorderSize = 0;
            this.btnMinimizeInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeInventory.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeInventory.Location = new System.Drawing.Point(1421, 5);
            this.btnMinimizeInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizeInventory.Name = "btnMinimizeInventory";
            this.btnMinimizeInventory.Size = new System.Drawing.Size(48, 41);
            this.btnMinimizeInventory.TabIndex = 3;
            this.btnMinimizeInventory.Text = "-";
            this.btnMinimizeInventory.UseVisualStyleBackColor = true;
            this.btnMinimizeInventory.Click += new System.EventHandler(this.btnMinimizeInventory_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1481, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(41, 738);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 49);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaleReport.FlatAppearance.BorderSize = 2;
            this.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReport.ForeColor = System.Drawing.Color.White;
            this.btnSaleReport.Location = new System.Drawing.Point(16, 144);
            this.btnSaleReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(243, 49);
            this.btnSaleReport.TabIndex = 17;
            this.btnSaleReport.Text = "Sales Report";
            this.btnSaleReport.UseVisualStyleBackColor = true;
            this.btnSaleReport.MouseEnter += new System.EventHandler(this.btnSaleReport_MouseEnter);
            this.btnSaleReport.MouseLeave += new System.EventHandler(this.btnSaleReport_MouseLeave);
            // 
            // iconPictureBoxSalesReport
            // 
            this.iconPictureBoxSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxSalesReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconPictureBoxSalesReport.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSalesReport.IconSize = 79;
            this.iconPictureBoxSalesReport.Location = new System.Drawing.Point(91, 69);
            this.iconPictureBoxSalesReport.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBoxSalesReport.Name = "iconPictureBoxSalesReport";
            this.iconPictureBoxSalesReport.Size = new System.Drawing.Size(87, 79);
            this.iconPictureBoxSalesReport.TabIndex = 16;
            this.iconPictureBoxSalesReport.TabStop = false;
            // 
            // btnMangeEmployee
            // 
            this.btnMangeEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMangeEmployee.FlatAppearance.BorderSize = 2;
            this.btnMangeEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeEmployee.ForeColor = System.Drawing.Color.White;
            this.btnMangeEmployee.Location = new System.Drawing.Point(16, 320);
            this.btnMangeEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnMangeEmployee.Name = "btnMangeEmployee";
            this.btnMangeEmployee.Size = new System.Drawing.Size(243, 98);
            this.btnMangeEmployee.TabIndex = 19;
            this.btnMangeEmployee.Text = "Manage Employee";
            this.btnMangeEmployee.UseVisualStyleBackColor = true;
            this.btnMangeEmployee.Click += new System.EventHandler(this.btnMangeSalesmen_Click);
            this.btnMangeEmployee.MouseEnter += new System.EventHandler(this.btnMangeSalesmen_MouseEnter);
            this.btnMangeEmployee.MouseLeave += new System.EventHandler(this.btnMangeSalesmen_MouseLeave);
            // 
            // iconPictureBoxManageSalesmen
            // 
            this.iconPictureBoxManageSalesmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageSalesmen.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBoxManageSalesmen.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageSalesmen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageSalesmen.IconSize = 79;
            this.iconPictureBoxManageSalesmen.Location = new System.Drawing.Point(91, 246);
            this.iconPictureBoxManageSalesmen.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBoxManageSalesmen.Name = "iconPictureBoxManageSalesmen";
            this.iconPictureBoxManageSalesmen.Size = new System.Drawing.Size(87, 79);
            this.iconPictureBoxManageSalesmen.TabIndex = 18;
            this.iconPictureBoxManageSalesmen.TabStop = false;
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageInventory.FlatAppearance.BorderSize = 2;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.ForeColor = System.Drawing.Color.White;
            this.btnManageInventory.Location = new System.Drawing.Point(15, 553);
            this.btnManageInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(243, 86);
            this.btnManageInventory.TabIndex = 21;
            this.btnManageInventory.Text = "Manage  Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            // 
            // iconPictureBoxInventory
            // 
            this.iconPictureBoxInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxInventory.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconPictureBoxInventory.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxInventory.IconSize = 79;
            this.iconPictureBoxInventory.Location = new System.Drawing.Point(95, 474);
            this.iconPictureBoxInventory.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBoxInventory.Name = "iconPictureBoxInventory";
            this.iconPictureBoxInventory.Size = new System.Drawing.Size(87, 79);
            this.iconPictureBoxInventory.TabIndex = 20;
            this.iconPictureBoxInventory.TabStop = false;
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageUsers.Controls.Add(this.pnlAdduser);
            this.pnlManageUsers.Controls.Add(this.pnlGridviewAllusers);
            this.pnlManageUsers.Controls.Add(this.lblManageEmployee);
            this.pnlManageUsers.Controls.Add(this.iconPictureBoxSalesmen);
            this.pnlManageUsers.Location = new System.Drawing.Point(277, 69);
            this.pnlManageUsers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(1239, 720);
            this.pnlManageUsers.TabIndex = 22;
            // 
            // pnlAdduser
            // 
            this.pnlAdduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlAdduser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdduser.Controls.Add(this.lblEmail);
            this.pnlAdduser.Controls.Add(this.txtEmail);
            this.pnlAdduser.Controls.Add(this.txtPhonenumber);
            this.pnlAdduser.Controls.Add(this.txtSalary);
            this.pnlAdduser.Controls.Add(this.dtpBirthdate);
            this.pnlAdduser.Controls.Add(this.dtpJoindate);
            this.pnlAdduser.Controls.Add(this.cmbGender);
            this.pnlAdduser.Controls.Add(this.lblSalary);
            this.pnlAdduser.Controls.Add(this.lblJoinDate);
            this.pnlAdduser.Controls.Add(this.lblBirthdate);
            this.pnlAdduser.Controls.Add(this.lblPhonenumber);
            this.pnlAdduser.Controls.Add(this.lblAddress);
            this.pnlAdduser.Controls.Add(this.txtAddress);
            this.pnlAdduser.Controls.Add(this.lblGender);
            this.pnlAdduser.Controls.Add(this.btnClear);
            this.pnlAdduser.Controls.Add(this.btnSave);
            this.pnlAdduser.Controls.Add(this.lblUserId);
            this.pnlAdduser.Controls.Add(this.txtUserId);
            this.pnlAdduser.Location = new System.Drawing.Point(13, 69);
            this.pnlAdduser.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAdduser.Name = "pnlAdduser";
            this.pnlAdduser.Size = new System.Drawing.Size(1214, 279);
            this.pnlAdduser.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(519, 207);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 28);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(647, 205);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(297, 30);
            this.txtEmail.TabIndex = 33;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenumber.Location = new System.Drawing.Point(151, 219);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(297, 30);
            this.txtPhonenumber.TabIndex = 32;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(647, 144);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(297, 30);
            this.txtSalary.TabIndex = 31;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(651, 25);
            this.dtpBirthdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(293, 29);
            this.dtpBirthdate.TabIndex = 30;
            // 
            // dtpJoindate
            // 
            this.dtpJoindate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoindate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoindate.Location = new System.Drawing.Point(651, 86);
            this.dtpJoindate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpJoindate.Name = "dtpJoindate";
            this.dtpJoindate.Size = new System.Drawing.Size(293, 29);
            this.dtpJoindate.TabIndex = 29;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(151, 82);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(296, 29);
            this.cmbGender.TabIndex = 27;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(519, 149);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(71, 28);
            this.lblSalary.TabIndex = 24;
            this.lblSalary.Text = "Salary";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Location = new System.Drawing.Point(519, 86);
            this.lblJoinDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(102, 28);
            this.lblJoinDate.TabIndex = 22;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.White;
            this.lblBirthdate.Location = new System.Drawing.Point(519, 25);
            this.lblBirthdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(111, 28);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birth Date";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonenumber.ForeColor = System.Drawing.Color.White;
            this.lblPhonenumber.Location = new System.Drawing.Point(23, 224);
            this.lblPhonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(105, 28);
            this.lblPhonenumber.TabIndex = 18;
            this.lblPhonenumber.Text = "Phone No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(23, 149);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 28);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(151, 149);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(297, 30);
            this.txtAddress.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(23, 81);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 28);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1040, 165);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 48);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1040, 75);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(23, 22);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(81, 28);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(151, 22);
            this.txtUserId.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(297, 30);
            this.txtUserId.TabIndex = 0;
            // 
            // pnlGridviewAllusers
            // 
            this.pnlGridviewAllusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlGridviewAllusers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridviewAllusers.Controls.Add(this.dgvSalesmen);
            this.pnlGridviewAllusers.Controls.Add(this.btnShowEmployee);
            this.pnlGridviewAllusers.Location = new System.Drawing.Point(13, 356);
            this.pnlGridviewAllusers.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridviewAllusers.Name = "pnlGridviewAllusers";
            this.pnlGridviewAllusers.Size = new System.Drawing.Size(1214, 347);
            this.pnlGridviewAllusers.TabIndex = 3;
            // 
            // dgvSalesmen
            // 
            this.dgvSalesmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesmen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.gender,
            this.address,
            this.phone,
            this.birthdate,
            this.join_date,
            this.salary,
            this.email});
            this.dgvSalesmen.Location = new System.Drawing.Point(4, 4);
            this.dgvSalesmen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalesmen.Name = "dgvSalesmen";
            this.dgvSalesmen.RowHeadersWidth = 51;
            this.dgvSalesmen.Size = new System.Drawing.Size(1204, 256);
            this.dgvSalesmen.TabIndex = 23;
            this.dgvSalesmen.DoubleClick += new System.EventHandler(this.dgvSalesmen_DoubleClick);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEmployee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmployee.ForeColor = System.Drawing.Color.White;
            this.btnShowEmployee.Location = new System.Drawing.Point(989, 297);
            this.btnShowEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(213, 41);
            this.btnShowEmployee.TabIndex = 11;
            this.btnShowEmployee.Text = "Show All Employee";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            this.btnShowEmployee.MouseEnter += new System.EventHandler(this.btnShowUsers_MouseEnter);
            this.btnShowEmployee.MouseLeave += new System.EventHandler(this.btnShowUsers_MouseLeave);
            // 
            // lblManageEmployee
            // 
            this.lblManageEmployee.AutoSize = true;
            this.lblManageEmployee.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageEmployee.ForeColor = System.Drawing.Color.White;
            this.lblManageEmployee.Location = new System.Drawing.Point(84, 20);
            this.lblManageEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManageEmployee.Name = "lblManageEmployee";
            this.lblManageEmployee.Size = new System.Drawing.Size(328, 37);
            this.lblManageEmployee.TabIndex = 1;
            this.lblManageEmployee.Text = "Employee  Management";
            // 
            // iconPictureBoxSalesmen
            // 
            this.iconPictureBoxSalesmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxSalesmen.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBoxSalesmen.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSalesmen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSalesmen.IconSize = 46;
            this.iconPictureBoxSalesmen.Location = new System.Drawing.Point(29, 15);
            this.iconPictureBoxSalesmen.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBoxSalesmen.Name = "iconPictureBoxSalesmen";
            this.iconPictureBoxSalesmen.Size = new System.Drawing.Size(49, 46);
            this.iconPictureBoxSalesmen.TabIndex = 0;
            this.iconPictureBoxSalesmen.TabStop = false;
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "UserId";
            this.user_id.HeaderText = "UserId";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "Gender";
            this.gender.HeaderText = "Gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.Width = 125;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "PhoneNumber";
            this.phone.HeaderText = "Phone";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // birthdate
            // 
            this.birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdate.DataPropertyName = "BirthDate";
            this.birthdate.HeaderText = "Birthdate";
            this.birthdate.MinimumWidth = 6;
            this.birthdate.Name = "birthdate";
            // 
            // join_date
            // 
            this.join_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.join_date.DataPropertyName = "JoinDate";
            this.join_date.HeaderText = "Join date";
            this.join_date.MinimumWidth = 6;
            this.join_date.Name = "join_date";
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "Salary";
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1533, 800);
            this.Controls.Add(this.pnlManageUsers);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.iconPictureBoxInventory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMangeEmployee);
            this.Controls.Add(this.iconPictureBoxManageSalesmen);
            this.Controls.Add(this.btnSaleReport);
            this.Controls.Add(this.iconPictureBoxSalesReport);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.pnlToMoveForm.ResumeLayout(false);
            this.pnlToMoveForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageSalesmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInventory)).EndInit();
            this.pnlManageUsers.ResumeLayout(false);
            this.pnlManageUsers.PerformLayout();
            this.pnlAdduser.ResumeLayout(false);
            this.pnlAdduser.PerformLayout();
            this.pnlGridviewAllusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToMoveForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSaleReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalesReport;
        private System.Windows.Forms.Button btnMangeEmployee;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageSalesmen;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.Button btnManageInventory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxInventory;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.Panel pnlAdduser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Panel pnlGridviewAllusers;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Label lblManageEmployee;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalesmen;
        private System.Windows.Forms.DataGridView dgvSalesmen;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.DateTimePicker dtpJoindate;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn join_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}