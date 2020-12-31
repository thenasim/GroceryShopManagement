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
            this.btnMangeSalesmen = new System.Windows.Forms.Button();
            this.iconPictureBoxManageSalesmen = new FontAwesome.Sharp.IconPictureBox();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.iconPictureBoxInventory = new FontAwesome.Sharp.IconPictureBox();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.pnlAdduser = new System.Windows.Forms.Panel();
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
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.pnlGridviewAllusers = new System.Windows.Forms.Panel();
            this.dgvSalesmen = new System.Windows.Forms.DataGridView();
            this.btnDeleteSalesman = new System.Windows.Forms.Button();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.lblManageSalesman = new System.Windows.Forms.Label();
            this.iconPictureBoxSalesmen = new FontAwesome.Sharp.IconPictureBox();
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
            this.pnlToMoveForm.Name = "pnlToMoveForm";
            this.pnlToMoveForm.Size = new System.Drawing.Size(1150, 41);
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
            this.btnSearchInventory.Location = new System.Drawing.Point(770, 7);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(28, 27);
            this.btnSearchInventory.TabIndex = 7;
            this.btnSearchInventory.UseVisualStyleBackColor = true;
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtSearchbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbar.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchbar.Location = new System.Drawing.Point(353, 8);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(413, 22);
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
            this.btnMinimizeInventory.Location = new System.Drawing.Point(1066, 4);
            this.btnMinimizeInventory.Name = "btnMinimizeInventory";
            this.btnMinimizeInventory.Size = new System.Drawing.Size(36, 33);
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
            this.btnClose.Location = new System.Drawing.Point(1111, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
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
            this.btnLogout.Location = new System.Drawing.Point(31, 600);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 40);
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
            this.btnSaleReport.Location = new System.Drawing.Point(12, 117);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(182, 40);
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
            this.iconPictureBoxSalesReport.IconSize = 64;
            this.iconPictureBoxSalesReport.Location = new System.Drawing.Point(68, 56);
            this.iconPictureBoxSalesReport.Name = "iconPictureBoxSalesReport";
            this.iconPictureBoxSalesReport.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxSalesReport.TabIndex = 16;
            this.iconPictureBoxSalesReport.TabStop = false;
            // 
            // btnMangeSalesmen
            // 
            this.btnMangeSalesmen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMangeSalesmen.FlatAppearance.BorderSize = 2;
            this.btnMangeSalesmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeSalesmen.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeSalesmen.ForeColor = System.Drawing.Color.White;
            this.btnMangeSalesmen.Location = new System.Drawing.Point(12, 260);
            this.btnMangeSalesmen.Name = "btnMangeSalesmen";
            this.btnMangeSalesmen.Size = new System.Drawing.Size(182, 80);
            this.btnMangeSalesmen.TabIndex = 19;
            this.btnMangeSalesmen.Text = "Manage Salesmen";
            this.btnMangeSalesmen.UseVisualStyleBackColor = true;
            this.btnMangeSalesmen.Click += new System.EventHandler(this.btnMangeSalesmen_Click);
            this.btnMangeSalesmen.MouseEnter += new System.EventHandler(this.btnMangeSalesmen_MouseEnter);
            this.btnMangeSalesmen.MouseLeave += new System.EventHandler(this.btnMangeSalesmen_MouseLeave);
            // 
            // iconPictureBoxManageSalesmen
            // 
            this.iconPictureBoxManageSalesmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageSalesmen.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBoxManageSalesmen.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageSalesmen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageSalesmen.IconSize = 64;
            this.iconPictureBoxManageSalesmen.Location = new System.Drawing.Point(68, 200);
            this.iconPictureBoxManageSalesmen.Name = "iconPictureBoxManageSalesmen";
            this.iconPictureBoxManageSalesmen.Size = new System.Drawing.Size(65, 64);
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
            this.btnManageInventory.Location = new System.Drawing.Point(11, 449);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(182, 70);
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
            this.iconPictureBoxInventory.IconSize = 64;
            this.iconPictureBoxInventory.Location = new System.Drawing.Point(71, 385);
            this.iconPictureBoxInventory.Name = "iconPictureBoxInventory";
            this.iconPictureBoxInventory.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxInventory.TabIndex = 20;
            this.iconPictureBoxInventory.TabStop = false;
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageUsers.Controls.Add(this.pnlAdduser);
            this.pnlManageUsers.Controls.Add(this.pnlGridviewAllusers);
            this.pnlManageUsers.Controls.Add(this.lblManageSalesman);
            this.pnlManageUsers.Controls.Add(this.iconPictureBoxSalesmen);
            this.pnlManageUsers.Location = new System.Drawing.Point(208, 56);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(930, 585);
            this.pnlManageUsers.TabIndex = 22;
            // 
            // pnlAdduser
            // 
            this.pnlAdduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlAdduser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnlAdduser.Controls.Add(this.lblAppId);
            this.pnlAdduser.Controls.Add(this.txtAppId);
            this.pnlAdduser.Location = new System.Drawing.Point(10, 56);
            this.pnlAdduser.Name = "pnlAdduser";
            this.pnlAdduser.Size = new System.Drawing.Size(911, 227);
            this.pnlAdduser.TabIndex = 2;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhonenumber.Location = new System.Drawing.Point(113, 178);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(224, 25);
            this.txtPhonenumber.TabIndex = 32;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(485, 117);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(224, 25);
            this.txtSalary.TabIndex = 31;
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthdate.Location = new System.Drawing.Point(488, 20);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(221, 25);
            this.dtpBirthdate.TabIndex = 30;
            // 
            // dtpJoindate
            // 
            this.dtpJoindate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoindate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJoindate.Location = new System.Drawing.Point(488, 70);
            this.dtpJoindate.Name = "dtpJoindate";
            this.dtpJoindate.Size = new System.Drawing.Size(221, 25);
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
            this.cmbGender.Location = new System.Drawing.Point(113, 67);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(223, 25);
            this.cmbGender.TabIndex = 27;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.White;
            this.lblSalary.Location = new System.Drawing.Point(395, 121);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(58, 21);
            this.lblSalary.TabIndex = 24;
            this.lblSalary.Text = "Salary";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoinDate.ForeColor = System.Drawing.Color.White;
            this.lblJoinDate.Location = new System.Drawing.Point(395, 70);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(82, 21);
            this.lblJoinDate.TabIndex = 22;
            this.lblJoinDate.Text = "Join Date";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.ForeColor = System.Drawing.Color.White;
            this.lblBirthdate.Location = new System.Drawing.Point(395, 20);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(87, 21);
            this.lblBirthdate.TabIndex = 20;
            this.lblBirthdate.Text = "Birth Date";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonenumber.ForeColor = System.Drawing.Color.White;
            this.lblPhonenumber.Location = new System.Drawing.Point(17, 182);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(86, 21);
            this.lblPhonenumber.TabIndex = 18;
            this.lblPhonenumber.Text = "Phone No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(17, 121);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 21);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(113, 121);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 25);
            this.txtAddress.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(17, 66);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 21);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Gender";
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(780, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 39);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(780, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppId.ForeColor = System.Drawing.Color.White;
            this.lblAppId.Location = new System.Drawing.Point(17, 18);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(65, 21);
            this.lblAppId.TabIndex = 1;
            this.lblAppId.Text = "User ID";
            // 
            // txtAppId
            // 
            this.txtAppId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppId.Location = new System.Drawing.Point(113, 18);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.ReadOnly = true;
            this.txtAppId.Size = new System.Drawing.Size(224, 25);
            this.txtAppId.TabIndex = 0;
            // 
            // pnlGridviewAllusers
            // 
            this.pnlGridviewAllusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlGridviewAllusers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridviewAllusers.Controls.Add(this.dgvSalesmen);
            this.pnlGridviewAllusers.Controls.Add(this.btnDeleteSalesman);
            this.pnlGridviewAllusers.Controls.Add(this.btnShowUsers);
            this.pnlGridviewAllusers.Location = new System.Drawing.Point(10, 289);
            this.pnlGridviewAllusers.Name = "pnlGridviewAllusers";
            this.pnlGridviewAllusers.Size = new System.Drawing.Size(911, 282);
            this.pnlGridviewAllusers.TabIndex = 3;
            // 
            // dgvSalesmen
            // 
            this.dgvSalesmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesmen.Location = new System.Drawing.Point(3, 3);
            this.dgvSalesmen.Name = "dgvSalesmen";
            this.dgvSalesmen.Size = new System.Drawing.Size(903, 208);
            this.dgvSalesmen.TabIndex = 23;
            // 
            // btnDeleteSalesman
            // 
            this.btnDeleteSalesman.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteSalesman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSalesman.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSalesman.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSalesman.Location = new System.Drawing.Point(543, 241);
            this.btnDeleteSalesman.Name = "btnDeleteSalesman";
            this.btnDeleteSalesman.Size = new System.Drawing.Size(160, 33);
            this.btnDeleteSalesman.TabIndex = 22;
            this.btnDeleteSalesman.Text = "DELETE";
            this.btnDeleteSalesman.UseVisualStyleBackColor = true;
            this.btnDeleteSalesman.MouseEnter += new System.EventHandler(this.btnDeleteSalesman_MouseEnter);
            this.btnDeleteSalesman.MouseLeave += new System.EventHandler(this.btnDeleteSalesman_MouseLeave);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowUsers.Location = new System.Drawing.Point(742, 241);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(160, 33);
            this.btnShowUsers.TabIndex = 11;
            this.btnShowUsers.Text = "Show All Salesman";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.MouseEnter += new System.EventHandler(this.btnShowUsers_MouseEnter);
            this.btnShowUsers.MouseLeave += new System.EventHandler(this.btnShowUsers_MouseLeave);
            // 
            // lblManageSalesman
            // 
            this.lblManageSalesman.AutoSize = true;
            this.lblManageSalesman.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSalesman.ForeColor = System.Drawing.Color.White;
            this.lblManageSalesman.Location = new System.Drawing.Point(63, 16);
            this.lblManageSalesman.Name = "lblManageSalesman";
            this.lblManageSalesman.Size = new System.Drawing.Size(241, 30);
            this.lblManageSalesman.TabIndex = 1;
            this.lblManageSalesman.Text = "Salesmen Management";
            // 
            // iconPictureBoxSalesmen
            // 
            this.iconPictureBoxSalesmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxSalesmen.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBoxSalesmen.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSalesmen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSalesmen.IconSize = 37;
            this.iconPictureBoxSalesmen.Location = new System.Drawing.Point(22, 12);
            this.iconPictureBoxSalesmen.Name = "iconPictureBoxSalesmen";
            this.iconPictureBoxSalesmen.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBoxSalesmen.TabIndex = 0;
            this.iconPictureBoxSalesmen.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlManageUsers);
            this.Controls.Add(this.btnManageInventory);
            this.Controls.Add(this.iconPictureBoxInventory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMangeSalesmen);
            this.Controls.Add(this.iconPictureBoxManageSalesmen);
            this.Controls.Add(this.btnSaleReport);
            this.Controls.Add(this.iconPictureBoxSalesReport);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnMangeSalesmen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageSalesmen;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.Button btnManageInventory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxInventory;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.Panel pnlAdduser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.Panel pnlGridviewAllusers;
        private System.Windows.Forms.Button btnDeleteSalesman;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Label lblManageSalesman;
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
    }
}