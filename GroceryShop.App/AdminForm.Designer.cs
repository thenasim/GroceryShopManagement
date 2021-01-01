namespace GroceryShop.App
{

    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.pnlToMoveForm = new System.Windows.Forms.Panel();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlFeaturesButtons = new System.Windows.Forms.Panel();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.btnManageInventory = new System.Windows.Forms.Button();
            this.iconPictureBoxInventory = new FontAwesome.Sharp.IconPictureBox();
            this.btnManageUers = new System.Windows.Forms.Button();
            this.iconPictureBoxManageUsers = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxSalesReport = new FontAwesome.Sharp.IconPictureBox();
            this.pnlManageUsers = new System.Windows.Forms.Panel();
            this.pnlAdduser = new System.Windows.Forms.Panel();
            this.cboUserType = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.lblAppId = new System.Windows.Forms.Label();
            this.txtAppId = new System.Windows.Forms.TextBox();
            this.pnlGridviewAllusers = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgvUsersGrid = new System.Windows.Forms.DataGridView();
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.iconPictureBoxUserManagement = new FontAwesome.Sharp.IconPictureBox();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.pnlSalesgraphs = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoWeeklyreport = new System.Windows.Forms.RadioButton();
            this.pnlGridviewSalesreport = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClearSalesReport = new System.Windows.Forms.Button();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.iconPictureBoxSale = new FontAwesome.Sharp.IconPictureBox();
            this.pnlToMoveForm.SuspendLayout();
            this.pnlFeaturesButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).BeginInit();
            this.pnlManageUsers.SuspendLayout();
            this.pnlAdduser.SuspendLayout();
            this.pnlGridviewAllusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUserManagement)).BeginInit();
            this.pnlSalesReport.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGridviewSalesreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSale)).BeginInit();
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
            this.pnlToMoveForm.TabIndex = 1;
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
            this.btnSearchInventory.Click += new System.EventHandler(this.btnSearchInventory_Click);
            this.btnSearchInventory.Leave += new System.EventHandler(this.btnSearchInventory_Leave);
            this.btnSearchInventory.MouseEnter += new System.EventHandler(this.btnSearchInventory_MouseEnter);
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
            this.txtSearchbar.Enter += new System.EventHandler(this.txtSearchbar_Enter);
            this.txtSearchbar.Leave += new System.EventHandler(this.txtSearchbar_Leave);
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
            this.btnClose.Location = new System.Drawing.Point(1111, 5);
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
            this.btnLogout.Location = new System.Drawing.Point(29, 555);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // pnlFeaturesButtons
            // 
            this.pnlFeaturesButtons.Controls.Add(this.btnLogout);
            this.pnlFeaturesButtons.Controls.Add(this.btnSaleReport);
            this.pnlFeaturesButtons.Controls.Add(this.btnManageInventory);
            this.pnlFeaturesButtons.Controls.Add(this.iconPictureBoxInventory);
            this.pnlFeaturesButtons.Controls.Add(this.btnManageUers);
            this.pnlFeaturesButtons.Controls.Add(this.iconPictureBoxManageUsers);
            this.pnlFeaturesButtons.Controls.Add(this.iconPictureBoxSalesReport);
            this.pnlFeaturesButtons.Controls.Add(this.pnlManageUsers);
            this.pnlFeaturesButtons.Controls.Add(this.pnlSalesReport);
            this.pnlFeaturesButtons.Location = new System.Drawing.Point(0, 41);
            this.pnlFeaturesButtons.Name = "pnlFeaturesButtons";
            this.pnlFeaturesButtons.Size = new System.Drawing.Size(1150, 609);
            this.pnlFeaturesButtons.TabIndex = 12;
            this.pnlFeaturesButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFeaturesButtons_Paint);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaleReport.FlatAppearance.BorderSize = 2;
            this.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReport.ForeColor = System.Drawing.Color.White;
            this.btnSaleReport.Location = new System.Drawing.Point(23, 224);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(162, 40);
            this.btnSaleReport.TabIndex = 13;
            this.btnSaleReport.Text = "Sales Report";
            this.btnSaleReport.UseVisualStyleBackColor = true;
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            this.btnSaleReport.MouseEnter += new System.EventHandler(this.btnSaleReport_MouseEnter);
            this.btnSaleReport.MouseLeave += new System.EventHandler(this.btnSaleReport_MouseLeave);
            // 
            // btnManageInventory
            // 
            this.btnManageInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageInventory.FlatAppearance.BorderSize = 2;
            this.btnManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInventory.ForeColor = System.Drawing.Color.White;
            this.btnManageInventory.Location = new System.Drawing.Point(23, 372);
            this.btnManageInventory.Name = "btnManageInventory";
            this.btnManageInventory.Size = new System.Drawing.Size(162, 74);
            this.btnManageInventory.TabIndex = 17;
            this.btnManageInventory.Text = "Manage  Inventory";
            this.btnManageInventory.UseVisualStyleBackColor = true;
            this.btnManageInventory.Click += new System.EventHandler(this.btnManageInventory_Click);
            this.btnManageInventory.MouseEnter += new System.EventHandler(this.btnManageInventory_MouseEnter);
            this.btnManageInventory.MouseLeave += new System.EventHandler(this.btnManageInventory_MouseLeave);
            // 
            // iconPictureBoxInventory
            // 
            this.iconPictureBoxInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxInventory.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconPictureBoxInventory.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxInventory.IconSize = 46;
            this.iconPictureBoxInventory.Location = new System.Drawing.Point(81, 326);
            this.iconPictureBoxInventory.Name = "iconPictureBoxInventory";
            this.iconPictureBoxInventory.Size = new System.Drawing.Size(46, 52);
            this.iconPictureBoxInventory.TabIndex = 16;
            this.iconPictureBoxInventory.TabStop = false;
            // 
            // btnManageUers
            // 
            this.btnManageUers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageUers.FlatAppearance.BorderSize = 2;
            this.btnManageUers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUers.ForeColor = System.Drawing.Color.White;
            this.btnManageUers.Location = new System.Drawing.Point(23, 73);
            this.btnManageUers.Name = "btnManageUers";
            this.btnManageUers.Size = new System.Drawing.Size(162, 40);
            this.btnManageUers.TabIndex = 11;
            this.btnManageUers.Text = "Manage Users";
            this.btnManageUers.UseVisualStyleBackColor = true;
            this.btnManageUers.Click += new System.EventHandler(this.btnManageUers_Click);
            this.btnManageUers.MouseEnter += new System.EventHandler(this.btnManageUers_MouseEnter);
            this.btnManageUers.MouseLeave += new System.EventHandler(this.btnManageUers_MouseLeave);
            // 
            // iconPictureBoxManageUsers
            // 
            this.iconPictureBoxManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBoxManageUsers.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageUsers.IconSize = 45;
            this.iconPictureBoxManageUsers.Location = new System.Drawing.Point(81, 29);
            this.iconPictureBoxManageUsers.Name = "iconPictureBoxManageUsers";
            this.iconPictureBoxManageUsers.Size = new System.Drawing.Size(46, 45);
            this.iconPictureBoxManageUsers.TabIndex = 0;
            this.iconPictureBoxManageUsers.TabStop = false;
            // 
            // iconPictureBoxSalesReport
            // 
            this.iconPictureBoxSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxSalesReport.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconPictureBoxSalesReport.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSalesReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSalesReport.IconSize = 45;
            this.iconPictureBoxSalesReport.Location = new System.Drawing.Point(81, 176);
            this.iconPictureBoxSalesReport.Name = "iconPictureBoxSalesReport";
            this.iconPictureBoxSalesReport.Size = new System.Drawing.Size(46, 45);
            this.iconPictureBoxSalesReport.TabIndex = 12;
            this.iconPictureBoxSalesReport.TabStop = false;
            // 
            // pnlManageUsers
            // 
            this.pnlManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageUsers.Controls.Add(this.pnlAdduser);
            this.pnlManageUsers.Controls.Add(this.pnlGridviewAllusers);
            this.pnlManageUsers.Controls.Add(this.lblManageUsers);
            this.pnlManageUsers.Controls.Add(this.iconPictureBoxUserManagement);
            this.pnlManageUsers.Location = new System.Drawing.Point(208, 12);
            this.pnlManageUsers.Name = "pnlManageUsers";
            this.pnlManageUsers.Size = new System.Drawing.Size(930, 585);
            this.pnlManageUsers.TabIndex = 4;
            // 
            // pnlAdduser
            // 
            this.pnlAdduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlAdduser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdduser.Controls.Add(this.cboUserType);
            this.pnlAdduser.Controls.Add(this.txtUserName);
            this.pnlAdduser.Controls.Add(this.txtPassword);
            this.pnlAdduser.Controls.Add(this.label4);
            this.pnlAdduser.Controls.Add(this.lblName);
            this.pnlAdduser.Controls.Add(this.lblPassword);
            this.pnlAdduser.Controls.Add(this.btnClearUser);
            this.pnlAdduser.Controls.Add(this.btnUserAdd);
            this.pnlAdduser.Controls.Add(this.lblAppId);
            this.pnlAdduser.Controls.Add(this.txtAppId);
            this.pnlAdduser.Location = new System.Drawing.Point(10, 56);
            this.pnlAdduser.Name = "pnlAdduser";
            this.pnlAdduser.Size = new System.Drawing.Size(911, 227);
            this.pnlAdduser.TabIndex = 2;
            // 
            // cboUserType
            // 
            this.cboUserType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUserType.FormattingEnabled = true;
            this.cboUserType.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cboUserType.Location = new System.Drawing.Point(287, 164);
            this.cboUserType.Name = "cboUserType";
            this.cboUserType.Size = new System.Drawing.Size(313, 25);
            this.cboUserType.TabIndex = 21;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(287, 116);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(313, 25);
            this.txtUserName.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(287, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(313, 25);
            this.txtPassword.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(161, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "User Type";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(161, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 21);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(161, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 21);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // btnClearUser
            // 
            this.btnClearUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUser.ForeColor = System.Drawing.Color.White;
            this.btnClearUser.Location = new System.Drawing.Point(660, 81);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(145, 40);
            this.btnClearUser.TabIndex = 12;
            this.btnClearUser.Text = "CLEAR";
            this.btnClearUser.UseVisualStyleBackColor = true;
            this.btnClearUser.Click += new System.EventHandler(this.btnClearUser_Click);
            this.btnClearUser.MouseEnter += new System.EventHandler(this.btnClearUser_MouseEnter);
            this.btnClearUser.MouseLeave += new System.EventHandler(this.btnClearUser_MouseLeave);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Location = new System.Drawing.Point(660, 18);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(145, 40);
            this.btnUserAdd.TabIndex = 11;
            this.btnUserAdd.Text = "ADD";
            this.btnUserAdd.UseVisualStyleBackColor = true;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            this.btnUserAdd.MouseEnter += new System.EventHandler(this.btnUserAdd_MouseEnter);
            this.btnUserAdd.MouseLeave += new System.EventHandler(this.btnUserAdd_MouseLeave);
            // 
            // lblAppId
            // 
            this.lblAppId.AutoSize = true;
            this.lblAppId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppId.ForeColor = System.Drawing.Color.White;
            this.lblAppId.Location = new System.Drawing.Point(161, 18);
            this.lblAppId.Name = "lblAppId";
            this.lblAppId.Size = new System.Drawing.Size(65, 21);
            this.lblAppId.TabIndex = 1;
            this.lblAppId.Text = "User ID";
            // 
            // txtAppId
            // 
            this.txtAppId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppId.Location = new System.Drawing.Point(287, 18);
            this.txtAppId.Name = "txtAppId";
            this.txtAppId.ReadOnly = true;
            this.txtAppId.Size = new System.Drawing.Size(313, 25);
            this.txtAppId.TabIndex = 0;
            // 
            // pnlGridviewAllusers
            // 
            this.pnlGridviewAllusers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlGridviewAllusers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridviewAllusers.Controls.Add(this.btnDeleteUser);
            this.pnlGridviewAllusers.Controls.Add(this.dgvUsersGrid);
            this.pnlGridviewAllusers.Controls.Add(this.btnShowUsers);
            this.pnlGridviewAllusers.Location = new System.Drawing.Point(10, 289);
            this.pnlGridviewAllusers.Name = "pnlGridviewAllusers";
            this.pnlGridviewAllusers.Size = new System.Drawing.Size(915, 276);
            this.pnlGridviewAllusers.TabIndex = 3;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(681, 237);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(102, 33);
            this.btnDeleteUser.TabIndex = 22;
            this.btnDeleteUser.Text = "DELETE";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            this.btnDeleteUser.MouseEnter += new System.EventHandler(this.btnDeleteUser_MouseEnter);
            this.btnDeleteUser.MouseLeave += new System.EventHandler(this.btnDeleteUser_MouseLeave);
            // 
            // dgvUsersGrid
            // 
            this.dgvUsersGrid.AllowUserToAddRows = false;
            this.dgvUsersGrid.AllowUserToDeleteRows = false;
            this.dgvUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appid,
            this.full_name,
            this.user_type,
            this.password});
            this.dgvUsersGrid.Location = new System.Drawing.Point(-1, 3);
            this.dgvUsersGrid.Name = "dgvUsersGrid";
            this.dgvUsersGrid.ReadOnly = true;
            this.dgvUsersGrid.RowHeadersWidth = 51;
            this.dgvUsersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersGrid.Size = new System.Drawing.Size(911, 229);
            this.dgvUsersGrid.TabIndex = 12;
            this.dgvUsersGrid.DoubleClick += new System.EventHandler(this.dgvUsersGrid_DoubleClick);
            // 
            // appid
            // 
            this.appid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appid.DataPropertyName = "AppId";
            this.appid.HeaderText = "UserId";
            this.appid.MinimumWidth = 6;
            this.appid.Name = "appid";
            this.appid.ReadOnly = true;
            // 
            // full_name
            // 
            this.full_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.full_name.DataPropertyName = "FullName";
            this.full_name.HeaderText = "User Name";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // user_type
            // 
            this.user_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_type.DataPropertyName = "UserType";
            this.user_type.HeaderText = "UserType";
            this.user_type.MinimumWidth = 6;
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "Password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsers.ForeColor = System.Drawing.Color.White;
            this.btnShowUsers.Location = new System.Drawing.Point(808, 237);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(102, 33);
            this.btnShowUsers.TabIndex = 11;
            this.btnShowUsers.Text = "Show Users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            this.btnShowUsers.MouseEnter += new System.EventHandler(this.btnShowUsers_MouseEnter);
            this.btnShowUsers.MouseLeave += new System.EventHandler(this.btnShowUsers_MouseLeave);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.White;
            this.lblManageUsers.Location = new System.Drawing.Point(63, 16);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(192, 30);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "User Management";
            // 
            // iconPictureBoxUserManagement
            // 
            this.iconPictureBoxUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxUserManagement.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBoxUserManagement.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxUserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUserManagement.IconSize = 37;
            this.iconPictureBoxUserManagement.Location = new System.Drawing.Point(22, 12);
            this.iconPictureBoxUserManagement.Name = "iconPictureBoxUserManagement";
            this.iconPictureBoxUserManagement.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBoxUserManagement.TabIndex = 0;
            this.iconPictureBoxUserManagement.TabStop = false;
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesReport.Controls.Add(this.pnlSalesgraphs);
            this.pnlSalesReport.Controls.Add(this.panel1);
            this.pnlSalesReport.Controls.Add(this.pnlGridviewSalesreport);
            this.pnlSalesReport.Controls.Add(this.lblSalesReport);
            this.pnlSalesReport.Controls.Add(this.iconPictureBoxSale);
            this.pnlSalesReport.Location = new System.Drawing.Point(208, 12);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(930, 583);
            this.pnlSalesReport.TabIndex = 18;
            // 
            // pnlSalesgraphs
            // 
            this.pnlSalesgraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlSalesgraphs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesgraphs.Location = new System.Drawing.Point(10, 107);
            this.pnlSalesgraphs.Name = "pnlSalesgraphs";
            this.pnlSalesgraphs.Size = new System.Drawing.Size(304, 463);
            this.pnlSalesgraphs.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rdoWeeklyreport);
            this.panel1.Location = new System.Drawing.Point(10, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 44);
            this.panel1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(153, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monthly Sales Report";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoWeeklyreport
            // 
            this.rdoWeeklyreport.AutoSize = true;
            this.rdoWeeklyreport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeeklyreport.ForeColor = System.Drawing.Color.White;
            this.rdoWeeklyreport.Location = new System.Drawing.Point(12, 15);
            this.rdoWeeklyreport.Name = "rdoWeeklyreport";
            this.rdoWeeklyreport.Size = new System.Drawing.Size(129, 17);
            this.rdoWeeklyreport.TabIndex = 0;
            this.rdoWeeklyreport.TabStop = true;
            this.rdoWeeklyreport.Text = "Weekly Sales Report";
            this.rdoWeeklyreport.UseVisualStyleBackColor = true;
            // 
            // pnlGridviewSalesreport
            // 
            this.pnlGridviewSalesreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlGridviewSalesreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridviewSalesreport.Controls.Add(this.dataGridView1);
            this.pnlGridviewSalesreport.Controls.Add(this.btnClearSalesReport);
            this.pnlGridviewSalesreport.Location = new System.Drawing.Point(328, 56);
            this.pnlGridviewSalesreport.Name = "pnlGridviewSalesreport";
            this.pnlGridviewSalesreport.Size = new System.Drawing.Size(589, 514);
            this.pnlGridviewSalesreport.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(576, 457);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnClearSalesReport
            // 
            this.btnClearSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSalesReport.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnClearSalesReport.Location = new System.Drawing.Point(471, 471);
            this.btnClearSalesReport.Name = "btnClearSalesReport";
            this.btnClearSalesReport.Size = new System.Drawing.Size(108, 32);
            this.btnClearSalesReport.TabIndex = 19;
            this.btnClearSalesReport.Text = "CLEAR";
            this.btnClearSalesReport.UseVisualStyleBackColor = true;
            this.btnClearSalesReport.MouseEnter += new System.EventHandler(this.btnClearSalesReport_MouseEnter);
            this.btnClearSalesReport.MouseLeave += new System.EventHandler(this.btnClearSalesReport_MouseLeave);
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.ForeColor = System.Drawing.Color.White;
            this.lblSalesReport.Location = new System.Drawing.Point(58, 18);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(144, 30);
            this.lblSalesReport.TabIndex = 3;
            this.lblSalesReport.Text = "Sales Reports";
            // 
            // iconPictureBoxSale
            // 
            this.iconPictureBoxSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxSale.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconPictureBoxSale.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSale.IconSize = 37;
            this.iconPictureBoxSale.Location = new System.Drawing.Point(19, 14);
            this.iconPictureBoxSale.Name = "iconPictureBoxSale";
            this.iconPictureBoxSale.Size = new System.Drawing.Size(37, 37);
            this.iconPictureBoxSale.TabIndex = 2;
            this.iconPictureBoxSale.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlFeaturesButtons);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnlToMoveForm.ResumeLayout(false);
            this.pnlToMoveForm.PerformLayout();
            this.pnlFeaturesButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).EndInit();
            this.pnlManageUsers.ResumeLayout(false);
            this.pnlManageUsers.PerformLayout();
            this.pnlAdduser.ResumeLayout(false);
            this.pnlAdduser.PerformLayout();
            this.pnlGridviewAllusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUserManagement)).EndInit();
            this.pnlSalesReport.ResumeLayout(false);
            this.pnlSalesReport.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlGridviewSalesreport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToMoveForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlFeaturesButtons;
        private System.Windows.Forms.Panel pnlManageUsers;
        private System.Windows.Forms.Label lblManageUsers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUserManagement;
        private System.Windows.Forms.Button btnManageUers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageUsers;
        private System.Windows.Forms.Button btnManageInventory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxInventory;
        private System.Windows.Forms.Button btnSaleReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalesReport;
        private System.Windows.Forms.Panel pnlSalesReport;
        private System.Windows.Forms.Label lblSalesReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSale;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Panel pnlGridviewAllusers;
        private System.Windows.Forms.Panel pnlAdduser;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Label lblAppId;
        private System.Windows.Forms.TextBox txtAppId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridView dgvUsersGrid;
        private System.Windows.Forms.ComboBox cboUserType;
        private System.Windows.Forms.Button btnDeleteUser;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Panel pnlGridviewSalesreport;
        private System.Windows.Forms.Panel pnlSalesgraphs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoWeeklyreport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearSalesReport;
    }
}