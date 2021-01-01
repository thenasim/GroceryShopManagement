namespace GroceryShop.App
{

    partial class SalesmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanForm));
            this.pnlToMoveForm = new System.Windows.Forms.Panel();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.iconPictureBoxManageCarts = new FontAwesome.Sharp.IconPictureBox();
            this.pnlEmployeeform = new System.Windows.Forms.Panel();
            this.pnlManageCarts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.lblTotalCartPrice = new System.Windows.Forms.Label();
            this.lsvCart = new System.Windows.Forms.ListView();
            this.ch_title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_product_quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_appid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInvoiceTotalPrice = new System.Windows.Forms.Label();
            this.btnClearInvoice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgbShowProduct = new System.Windows.Forms.DataGridView();
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trkQuantity = new System.Windows.Forms.TrackBar();
            this.txtQunatity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlToMoveForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).BeginInit();
            this.pnlEmployeeform.SuspendLayout();
            this.pnlManageCarts.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuantity)).BeginInit();
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
            this.btnSearchInventory.MouseEnter += new System.EventHandler(this.btnSearchInventory_MouseEnter);
            this.btnSearchInventory.MouseLeave += new System.EventHandler(this.btnSearchInventory_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(13, 562);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(126, 31);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
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
            this.txtSearchbar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchbar_KeyUp);
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
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.White;
            this.lblManageUsers.Location = new System.Drawing.Point(49, 6);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(54, 30);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Cart";
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
            // iconPictureBoxManageCarts
            // 
            this.iconPictureBoxManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxManageCarts.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBoxManageCarts.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageCarts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageCarts.IconSize = 35;
            this.iconPictureBoxManageCarts.Location = new System.Drawing.Point(5, 4);
            this.iconPictureBoxManageCarts.Name = "iconPictureBoxManageCarts";
            this.iconPictureBoxManageCarts.Size = new System.Drawing.Size(38, 35);
            this.iconPictureBoxManageCarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxManageCarts.TabIndex = 0;
            this.iconPictureBoxManageCarts.TabStop = false;
            // 
            // pnlEmployeeform
            // 
            this.pnlEmployeeform.Controls.Add(this.pnlManageCarts);
            this.pnlEmployeeform.Location = new System.Drawing.Point(3, 41);
            this.pnlEmployeeform.Name = "pnlEmployeeform";
            this.pnlEmployeeform.Size = new System.Drawing.Size(1147, 609);
            this.pnlEmployeeform.TabIndex = 3;
            this.pnlEmployeeform.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEmployeeform_Paint);
            // 
            // pnlManageCarts
            // 
            this.pnlManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageCarts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageCarts.Controls.Add(this.panel2);
            this.pnlManageCarts.Controls.Add(this.btnLogout);
            this.pnlManageCarts.Controls.Add(this.panel1);
            this.pnlManageCarts.Controls.Add(this.lblManageUsers);
            this.pnlManageCarts.Controls.Add(this.iconPictureBoxManageCarts);
            this.pnlManageCarts.Location = new System.Drawing.Point(-3, 1);
            this.pnlManageCarts.Name = "pnlManageCarts";
            this.pnlManageCarts.Size = new System.Drawing.Size(1150, 606);
            this.pnlManageCarts.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPrintInvoice);
            this.panel2.Controls.Add(this.pnlInvoice);
            this.panel2.Controls.Add(this.btnClearInvoice);
            this.panel2.Location = new System.Drawing.Point(580, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 590);
            this.panel2.TabIndex = 3;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Location = new System.Drawing.Point(285, 547);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(100, 27);
            this.btnPrintInvoice.TabIndex = 32;
            this.btnPrintInvoice.Text = "PRINT";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            this.btnPrintInvoice.MouseEnter += new System.EventHandler(this.btnPrintInvoice_MouseEnter);
            this.btnPrintInvoice.MouseLeave += new System.EventHandler(this.btnPrintInvoice_MouseLeave);
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoice.Controls.Add(this.lblTotalCartPrice);
            this.pnlInvoice.Controls.Add(this.lsvCart);
            this.pnlInvoice.Controls.Add(this.lblInvoiceTotalPrice);
            this.pnlInvoice.Location = new System.Drawing.Point(2, 9);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(553, 510);
            this.pnlInvoice.TabIndex = 31;
            // 
            // lblTotalCartPrice
            // 
            this.lblTotalCartPrice.AutoSize = true;
            this.lblTotalCartPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartPrice.ForeColor = System.Drawing.Color.White;
            this.lblTotalCartPrice.Location = new System.Drawing.Point(380, 474);
            this.lblTotalCartPrice.Name = "lblTotalCartPrice";
            this.lblTotalCartPrice.Size = new System.Drawing.Size(17, 18);
            this.lblTotalCartPrice.TabIndex = 3;
            this.lblTotalCartPrice.Text = "0";
            // 
            // lsvCart
            // 
            this.lsvCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lsvCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_title,
            this.ch_quantity,
            this.ch_price,
            this.ch_total,
            this.ch_product_quantity,
            this.ch_appid});
            this.lsvCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvCart.ForeColor = System.Drawing.Color.White;
            this.lsvCart.HideSelection = false;
            this.lsvCart.Location = new System.Drawing.Point(5, 16);
            this.lsvCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvCart.MultiSelect = false;
            this.lsvCart.Name = "lsvCart";
            this.lsvCart.Size = new System.Drawing.Size(541, 445);
            this.lsvCart.TabIndex = 2;
            this.lsvCart.UseCompatibleStateImageBehavior = false;
            this.lsvCart.View = System.Windows.Forms.View.Details;
            // 
            // ch_title
            // 
            this.ch_title.Text = "Title";
            this.ch_title.Width = 304;
            // 
            // ch_quantity
            // 
            this.ch_quantity.Text = "Quantity";
            this.ch_quantity.Width = 131;
            // 
            // ch_price
            // 
            this.ch_price.Text = "Price";
            this.ch_price.Width = 120;
            // 
            // ch_total
            // 
            this.ch_total.Text = "Total";
            this.ch_total.Width = 146;
            // 
            // ch_product_quantity
            // 
            this.ch_product_quantity.Text = "Product Quantity";
            this.ch_product_quantity.Width = 0;
            // 
            // ch_appid
            // 
            this.ch_appid.Text = "AppId";
            this.ch_appid.Width = 0;
            // 
            // lblInvoiceTotalPrice
            // 
            this.lblInvoiceTotalPrice.AutoSize = true;
            this.lblInvoiceTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTotalPrice.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceTotalPrice.Location = new System.Drawing.Point(289, 476);
            this.lblInvoiceTotalPrice.Name = "lblInvoiceTotalPrice";
            this.lblInvoiceTotalPrice.Size = new System.Drawing.Size(92, 16);
            this.lblInvoiceTotalPrice.TabIndex = 0;
            this.lblInvoiceTotalPrice.Text = "Total Price :";
            // 
            // btnClearInvoice
            // 
            this.btnClearInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInvoice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInvoice.ForeColor = System.Drawing.Color.White;
            this.btnClearInvoice.Location = new System.Drawing.Point(420, 547);
            this.btnClearInvoice.Name = "btnClearInvoice";
            this.btnClearInvoice.Size = new System.Drawing.Size(100, 27);
            this.btnClearInvoice.TabIndex = 30;
            this.btnClearInvoice.Text = "CLEAR";
            this.btnClearInvoice.UseVisualStyleBackColor = true;
            this.btnClearInvoice.Click += new System.EventHandler(this.btnClearInvoice_Click);
            this.btnClearInvoice.MouseEnter += new System.EventHandler(this.btnClearInvoice_MouseEnter);
            this.btnClearInvoice.MouseLeave += new System.EventHandler(this.btnClearInvoice_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgbShowProduct);
            this.panel1.Controls.Add(this.trkQuantity);
            this.panel1.Controls.Add(this.txtQunatity);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.btnADD);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(5, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 478);
            this.panel1.TabIndex = 2;
            // 
            // dgbShowProduct
            // 
            this.dgbShowProduct.AllowUserToAddRows = false;
            this.dgbShowProduct.AllowUserToDeleteRows = false;
            this.dgbShowProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbShowProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appid,
            this.title,
            this.price,
            this.quantity,
            this.category_name});
            this.dgbShowProduct.Location = new System.Drawing.Point(7, 9);
            this.dgbShowProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgbShowProduct.Name = "dgbShowProduct";
            this.dgbShowProduct.ReadOnly = true;
            this.dgbShowProduct.RowHeadersWidth = 51;
            this.dgbShowProduct.RowTemplate.Height = 24;
            this.dgbShowProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbShowProduct.Size = new System.Drawing.Size(545, 313);
            this.dgbShowProduct.TabIndex = 36;
            this.dgbShowProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbShowProduct_CellClick);
            // 
            // appid
            // 
            this.appid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appid.DataPropertyName = "AppId";
            this.appid.HeaderText = "AppId";
            this.appid.MinimumWidth = 6;
            this.appid.Name = "appid";
            this.appid.ReadOnly = true;
            this.appid.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.DataPropertyName = "Price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 56;
            // 
            // quantity
            // 
            this.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.quantity.DataPropertyName = "Quantity";
            this.quantity.HeaderText = "Available";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 75;
            // 
            // category_name
            // 
            this.category_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category_name.DataPropertyName = "CategoryName";
            this.category_name.HeaderText = "Category";
            this.category_name.MinimumWidth = 6;
            this.category_name.Name = "category_name";
            this.category_name.ReadOnly = true;
            // 
            // trkQuantity
            // 
            this.trkQuantity.Enabled = false;
            this.trkQuantity.Location = new System.Drawing.Point(180, 349);
            this.trkQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trkQuantity.Minimum = 1;
            this.trkQuantity.Name = "trkQuantity";
            this.trkQuantity.Size = new System.Drawing.Size(372, 45);
            this.trkQuantity.TabIndex = 19;
            this.trkQuantity.Value = 1;
            this.trkQuantity.Scroll += new System.EventHandler(this.trkQuantity_Scroll);
            // 
            // txtQunatity
            // 
            this.txtQunatity.Enabled = false;
            this.txtQunatity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunatity.Location = new System.Drawing.Point(9, 363);
            this.txtQunatity.Name = "txtQunatity";
            this.txtQunatity.Size = new System.Drawing.Size(96, 29);
            this.txtQunatity.TabIndex = 35;
            this.txtQunatity.Text = "1";
            this.txtQunatity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQunatity_KeyUp);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(5, 335);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnADD
            // 
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(300, 424);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(104, 36);
            this.btnADD.TabIndex = 29;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            this.btnADD.MouseEnter += new System.EventHandler(this.btnADD_MouseEnter);
            this.btnADD.MouseLeave += new System.EventHandler(this.btnADD_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(427, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 36);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // SalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlEmployeeform);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.Shown += new System.EventHandler(this.SalesmanForm_Shown);
            this.pnlToMoveForm.ResumeLayout(false);
            this.pnlToMoveForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).EndInit();
            this.pnlEmployeeform.ResumeLayout(false);
            this.pnlManageCarts.ResumeLayout(false);
            this.pnlManageCarts.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbShowProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToMoveForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Panel pnlEmployeeform;
        private System.Windows.Forms.Panel pnlManageCarts;
        private System.Windows.Forms.Label lblManageUsers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageCarts;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.TextBox txtSearchbar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Label lblInvoiceTotalPrice;
        private System.Windows.Forms.Button btnClearInvoice;
        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TrackBar trkQuantity;
        private System.Windows.Forms.DataGridView dgbShowProduct;
        private System.Windows.Forms.ListView lsvCart;
        private System.Windows.Forms.ColumnHeader ch_title;
        private System.Windows.Forms.ColumnHeader ch_quantity;
        private System.Windows.Forms.ColumnHeader ch_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_name;
        private System.Windows.Forms.ColumnHeader ch_total;
        private System.Windows.Forms.Label lblTotalCartPrice;
        private System.Windows.Forms.ColumnHeader ch_product_quantity;
        private System.Windows.Forms.ColumnHeader ch_appid;
    }
}