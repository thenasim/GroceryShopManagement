namespace GroceryShop.App
{

    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.pnlToMoveForm = new System.Windows.Forms.Panel();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlEmployeeform = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlManageCarts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.iconPictureBoxManageCarts = new FontAwesome.Sharp.IconPictureBox();
            this.btnMangeCarts = new System.Windows.Forms.Button();
            this.iconPictureBoxManageCart = new FontAwesome.Sharp.IconPictureBox();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.iconPictureBoxSalesReport = new FontAwesome.Sharp.IconPictureBox();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.lblInvoiceTotalPrice = new System.Windows.Forms.Label();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbProductTitle = new System.Windows.Forms.ComboBox();
            this.txtCartPrice = new System.Windows.Forms.TextBox();
            this.txtQunatity = new System.Windows.Forms.TextBox();
            this.pnlToMoveForm.SuspendLayout();
            this.pnlEmployeeform.SuspendLayout();
            this.pnlManageCarts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).BeginInit();
            this.pnlInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.btnSearchInventory.MouseEnter += new System.EventHandler(this.btnSearchInventory_MouseEnter);
            this.btnSearchInventory.MouseLeave += new System.EventHandler(this.btnSearchInventory_MouseLeave);
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
            // pnlEmployeeform
            // 
            this.pnlEmployeeform.Controls.Add(this.btnLogout);
            this.pnlEmployeeform.Controls.Add(this.pnlManageCarts);
            this.pnlEmployeeform.Controls.Add(this.btnMangeCarts);
            this.pnlEmployeeform.Controls.Add(this.iconPictureBoxManageCart);
            this.pnlEmployeeform.Controls.Add(this.btnSaleReport);
            this.pnlEmployeeform.Controls.Add(this.iconPictureBoxSalesReport);
            this.pnlEmployeeform.Location = new System.Drawing.Point(3, 41);
            this.pnlEmployeeform.Name = "pnlEmployeeform";
            this.pnlEmployeeform.Size = new System.Drawing.Size(1147, 609);
            this.pnlEmployeeform.TabIndex = 3;
            this.pnlEmployeeform.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployeeform_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(26, 553);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(145, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // pnlManageCarts
            // 
            this.pnlManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageCarts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageCarts.Controls.Add(this.panel2);
            this.pnlManageCarts.Controls.Add(this.panel1);
            this.pnlManageCarts.Controls.Add(this.lblManageUsers);
            this.pnlManageCarts.Controls.Add(this.iconPictureBoxManageCarts);
            this.pnlManageCarts.Location = new System.Drawing.Point(208, 5);
            this.pnlManageCarts.Name = "pnlManageCarts";
            this.pnlManageCarts.Size = new System.Drawing.Size(927, 591);
            this.pnlManageCarts.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrintInvoice);
            this.panel2.Controls.Add(this.pnlInvoice);
            this.panel2.Controls.Add(this.btnClearInvoice);
            this.panel2.Location = new System.Drawing.Point(353, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 507);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtQunatity);
            this.panel1.Controls.Add(this.txtCartPrice);
            this.panel1.Controls.Add(this.cmbProductTitle);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Location = new System.Drawing.Point(10, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 507);
            this.panel1.TabIndex = 2;
            // 
            // btnADD
            // 
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(19, 450);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(115, 36);
            this.btnADD.TabIndex = 29;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.MouseEnter += new System.EventHandler(this.btnADD_MouseEnter);
            this.btnADD.MouseLeave += new System.EventHandler(this.btnADD_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(151, 450);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 36);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product TItle";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(15, 341);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(71, 21);
            this.lblDiscount.TabIndex = 26;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(19, 365);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(295, 29);
            this.txtDiscount.TabIndex = 25;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(15, 265);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 24;
            this.lblPrice.Text = "Price";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(19, 49);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(292, 29);
            this.cboCategory.TabIndex = 22;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(15, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 21);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.White;
            this.lblManageUsers.Location = new System.Drawing.Point(54, 18);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(54, 30);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Cart";
            // 
            // iconPictureBoxManageCarts
            // 
            this.iconPictureBoxManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxManageCarts.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBoxManageCarts.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageCarts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageCarts.IconSize = 42;
            this.iconPictureBoxManageCarts.Location = new System.Drawing.Point(10, 13);
            this.iconPictureBoxManageCarts.Name = "iconPictureBoxManageCarts";
            this.iconPictureBoxManageCarts.Size = new System.Drawing.Size(50, 42);
            this.iconPictureBoxManageCarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxManageCarts.TabIndex = 0;
            this.iconPictureBoxManageCarts.TabStop = false;
            // 
            // btnMangeCarts
            // 
            this.btnMangeCarts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMangeCarts.FlatAppearance.BorderSize = 2;
            this.btnMangeCarts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeCarts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMangeCarts.ForeColor = System.Drawing.Color.White;
            this.btnMangeCarts.Location = new System.Drawing.Point(11, 314);
            this.btnMangeCarts.Name = "btnMangeCarts";
            this.btnMangeCarts.Size = new System.Drawing.Size(182, 40);
            this.btnMangeCarts.TabIndex = 17;
            this.btnMangeCarts.Text = "Manage Carts";
            this.btnMangeCarts.UseVisualStyleBackColor = true;
            this.btnMangeCarts.Click += new System.EventHandler(this.btnMangeCarts_Click);
            this.btnMangeCarts.MouseEnter += new System.EventHandler(this.btnMangeCarts_MouseEnter);
            this.btnMangeCarts.MouseLeave += new System.EventHandler(this.btnMangeCarts_MouseLeave);
            // 
            // iconPictureBoxManageCart
            // 
            this.iconPictureBoxManageCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBoxManageCart.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageCart.IconSize = 64;
            this.iconPictureBoxManageCart.Location = new System.Drawing.Point(67, 254);
            this.iconPictureBoxManageCart.Name = "iconPictureBoxManageCart";
            this.iconPictureBoxManageCart.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxManageCart.TabIndex = 16;
            this.iconPictureBoxManageCart.TabStop = false;
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaleReport.FlatAppearance.BorderSize = 2;
            this.btnSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleReport.ForeColor = System.Drawing.Color.White;
            this.btnSaleReport.Location = new System.Drawing.Point(11, 134);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(182, 40);
            this.btnSaleReport.TabIndex = 15;
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
            this.iconPictureBoxSalesReport.Location = new System.Drawing.Point(67, 73);
            this.iconPictureBoxSalesReport.Name = "iconPictureBoxSalesReport";
            this.iconPictureBoxSalesReport.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxSalesReport.TabIndex = 14;
            this.iconPictureBoxSalesReport.TabStop = false;
            // 
            // btnClearInvoice
            // 
            this.btnClearInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInvoice.ForeColor = System.Drawing.Color.White;
            this.btnClearInvoice.Location = new System.Drawing.Point(450, 467);
            this.btnClearInvoice.Name = "btnClearInvoice";
            this.btnClearInvoice.Size = new System.Drawing.Size(100, 27);
            this.btnClearInvoice.TabIndex = 30;
            this.btnClearInvoice.Text = "CLEAR";
            this.btnClearInvoice.UseVisualStyleBackColor = true;
            this.btnClearInvoice.MouseEnter += new System.EventHandler(this.btnClearInvoice_MouseEnter);
            this.btnClearInvoice.MouseLeave += new System.EventHandler(this.btnClearInvoice_MouseLeave);
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.dataGridView1);
            this.pnlInvoice.Controls.Add(this.textBox1);
            this.pnlInvoice.Controls.Add(this.lblInvoiceTotalPrice);
            this.pnlInvoice.Location = new System.Drawing.Point(10, 14);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(541, 439);
            this.pnlInvoice.TabIndex = 31;
            // 
            // lblInvoiceTotalPrice
            // 
            this.lblInvoiceTotalPrice.AutoSize = true;
            this.lblInvoiceTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceTotalPrice.Location = new System.Drawing.Point(298, 411);
            this.lblInvoiceTotalPrice.Name = "lblInvoiceTotalPrice";
            this.lblInvoiceTotalPrice.Size = new System.Drawing.Size(84, 16);
            this.lblInvoiceTotalPrice.TabIndex = 0;
            this.lblInvoiceTotalPrice.Text = "Total Price";
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Location = new System.Drawing.Point(330, 468);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(100, 27);
            this.btnPrintInvoice.TabIndex = 32;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.MouseEnter += new System.EventHandler(this.btnPrintInvoice_MouseEnter);
            this.btnPrintInvoice.MouseLeave += new System.EventHandler(this.btnPrintInvoice_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 392);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(15, 187);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbProductTitle
            // 
            this.cmbProductTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductTitle.FormattingEnabled = true;
            this.cmbProductTitle.Location = new System.Drawing.Point(19, 128);
            this.cmbProductTitle.Name = "cmbProductTitle";
            this.cmbProductTitle.Size = new System.Drawing.Size(292, 29);
            this.cmbProductTitle.TabIndex = 32;
            // 
            // txtCartPrice
            // 
            this.txtCartPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartPrice.Location = new System.Drawing.Point(19, 289);
            this.txtCartPrice.Name = "txtCartPrice";
            this.txtCartPrice.ReadOnly = true;
            this.txtCartPrice.Size = new System.Drawing.Size(295, 29);
            this.txtCartPrice.TabIndex = 34;
            // 
            // txtQunatity
            // 
            this.txtQunatity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunatity.Location = new System.Drawing.Point(19, 216);
            this.txtQunatity.Name = "txtQunatity";
            this.txtQunatity.Size = new System.Drawing.Size(295, 29);
            this.txtQunatity.TabIndex = 35;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlEmployeeform);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.pnlToMoveForm.ResumeLayout(false);
            this.pnlToMoveForm.PerformLayout();
            this.pnlEmployeeform.ResumeLayout(false);
            this.pnlManageCarts.ResumeLayout(false);
            this.pnlManageCarts.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).EndInit();
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToMoveForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Panel pnlEmployeeform;
        private System.Windows.Forms.Button btnSaleReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalesReport;
        private System.Windows.Forms.Button btnMangeCarts;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageCart;
        private System.Windows.Forms.Panel pnlManageCarts;
        private System.Windows.Forms.Label lblManageUsers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageCarts;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblInvoiceTotalPrice;
        private System.Windows.Forms.Button btnClearInvoice;
        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.TextBox txtCartPrice;
        private System.Windows.Forms.ComboBox cmbProductTitle;
        private System.Windows.Forms.Label lblQuantity;
    }
}