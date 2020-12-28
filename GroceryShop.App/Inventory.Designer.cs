namespace GroceryShop.App
{

    partial class Inventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.pnlProductlist = new System.Windows.Forms.Panel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlGridview = new System.Windows.Forms.Panel();
            this.dgvProductdetails = new System.Windows.Forms.DataGridView();
            this.btnShowdetails = new System.Windows.Forms.Button();
            this.btnCloseInventory = new System.Windows.Forms.Button();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.lblInventoryname = new System.Windows.Forms.Label();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlForSearchbar = new System.Windows.Forms.Panel();
            this.pnlProductlist.SuspendLayout();
            this.pnlGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductdetails)).BeginInit();
            this.pnlForSearchbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProductlist
            // 
            this.pnlProductlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnlProductlist.Controls.Add(this.cboCategory);
            this.pnlProductlist.Controls.Add(this.lblQuantity);
            this.pnlProductlist.Controls.Add(this.lblCategory);
            this.pnlProductlist.Controls.Add(this.lblPurchasePrice);
            this.pnlProductlist.Controls.Add(this.lblPrice);
            this.pnlProductlist.Controls.Add(this.txtQuantity);
            this.pnlProductlist.Controls.Add(this.txtPurchasePrice);
            this.pnlProductlist.Controls.Add(this.txtPrice);
            this.pnlProductlist.Controls.Add(this.lblProductTitle);
            this.pnlProductlist.Controls.Add(this.txtProductTitle);
            this.pnlProductlist.Controls.Add(this.btnADD);
            this.pnlProductlist.Controls.Add(this.btnClear);
            this.pnlProductlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProductlist.Location = new System.Drawing.Point(0, 41);
            this.pnlProductlist.Name = "pnlProductlist";
            this.pnlProductlist.Size = new System.Drawing.Size(329, 600);
            this.pnlProductlist.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(20, 301);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(292, 29);
            this.cboCategory.TabIndex = 20;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(23, 371);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(23, 276);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 21);
            this.lblCategory.TabIndex = 18;
            this.lblCategory.Text = "Category";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.ForeColor = System.Drawing.Color.White;
            this.lblPurchasePrice.Location = new System.Drawing.Point(23, 194);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(111, 21);
            this.lblPurchasePrice.TabIndex = 17;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(23, 114);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 21);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(20, 395);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(295, 29);
            this.txtQuantity.TabIndex = 14;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(20, 218);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(295, 29);
            this.txtPurchasePrice.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(20, 138);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(295, 29);
            this.txtPrice.TabIndex = 12;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductTitle.Location = new System.Drawing.Point(23, 33);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(97, 21);
            this.lblProductTitle.TabIndex = 11;
            this.lblProductTitle.Text = "Product TItle";
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTitle.Location = new System.Drawing.Point(20, 64);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(295, 29);
            this.txtProductTitle.TabIndex = 10;
            // 
            // btnADD
            // 
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(50, 516);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(86, 42);
            this.btnADD.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(200, 516);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 42);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // pnlGridview
            // 
            this.pnlGridview.Controls.Add(this.dgvProductdetails);
            this.pnlGridview.Controls.Add(this.btnShowdetails);
            this.pnlGridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridview.Location = new System.Drawing.Point(332, 41);
            this.pnlGridview.Name = "pnlGridview";
            this.pnlGridview.Size = new System.Drawing.Size(832, 600);
            this.pnlGridview.TabIndex = 5;
            // 
            // dgvProductdetails
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductdetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductdetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvProductdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductdetails.GridColor = System.Drawing.Color.Black;
            this.dgvProductdetails.Location = new System.Drawing.Point(0, 3);
            this.dgvProductdetails.Name = "dgvProductdetails";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductdetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductdetails.RowHeadersWidth = 51;
            this.dgvProductdetails.Size = new System.Drawing.Size(828, 497);
            this.dgvProductdetails.TabIndex = 7;
            // 
            // btnShowdetails
            // 
            this.btnShowdetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowdetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowdetails.ForeColor = System.Drawing.Color.White;
            this.btnShowdetails.Location = new System.Drawing.Point(626, 529);
            this.btnShowdetails.Name = "btnShowdetails";
            this.btnShowdetails.Size = new System.Drawing.Size(194, 42);
            this.btnShowdetails.TabIndex = 6;
            this.btnShowdetails.Text = "Show Details";
            this.btnShowdetails.UseVisualStyleBackColor = true;
            this.btnShowdetails.Click += new System.EventHandler(this.btnShowdetails_Click);
            this.btnShowdetails.MouseEnter += new System.EventHandler(this.btnShowdetails_MouseEnter);
            this.btnShowdetails.MouseLeave += new System.EventHandler(this.btnShowdetails_MouseLeave);
            // 
            // btnCloseInventory
            // 
            this.btnCloseInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnCloseInventory.FlatAppearance.BorderSize = 0;
            this.btnCloseInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInventory.ForeColor = System.Drawing.Color.White;
            this.btnCloseInventory.Location = new System.Drawing.Point(1119, 3);
            this.btnCloseInventory.Name = "btnCloseInventory";
            this.btnCloseInventory.Size = new System.Drawing.Size(34, 33);
            this.btnCloseInventory.TabIndex = 1;
            this.btnCloseInventory.Text = "X";
            this.btnCloseInventory.UseVisualStyleBackColor = true;
            this.btnCloseInventory.Click += new System.EventHandler(this.btnCloseInventory_Click);
            this.btnCloseInventory.MouseEnter += new System.EventHandler(this.btnCloseInventory_MouseEnter);
            this.btnCloseInventory.MouseLeave += new System.EventHandler(this.btnCloseInventory_MouseLeave);
            // 
            // btnMinimizeInventory
            // 
            this.btnMinimizeInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnMinimizeInventory.FlatAppearance.BorderSize = 0;
            this.btnMinimizeInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeInventory.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeInventory.Location = new System.Drawing.Point(1077, 2);
            this.btnMinimizeInventory.Name = "btnMinimizeInventory";
            this.btnMinimizeInventory.Size = new System.Drawing.Size(36, 33);
            this.btnMinimizeInventory.TabIndex = 2;
            this.btnMinimizeInventory.Text = "-";
            this.btnMinimizeInventory.UseVisualStyleBackColor = true;
            this.btnMinimizeInventory.Click += new System.EventHandler(this.btnMinimizeInventory_Click);
            // 
            // lblInventoryname
            // 
            this.lblInventoryname.AutoSize = true;
            this.lblInventoryname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInventoryname.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryname.ForeColor = System.Drawing.Color.White;
            this.lblInventoryname.Location = new System.Drawing.Point(14, 4);
            this.lblInventoryname.Name = "lblInventoryname";
            this.lblInventoryname.Size = new System.Drawing.Size(129, 32);
            this.lblInventoryname.TabIndex = 3;
            this.lblInventoryname.Text = "Inventory";
            // 
            // txtSearchbar
            // 
            this.txtSearchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtSearchbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchbar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchbar.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchbar.Location = new System.Drawing.Point(381, 6);
            this.txtSearchbar.Name = "txtSearchbar";
            this.txtSearchbar.Size = new System.Drawing.Size(413, 29);
            this.txtSearchbar.TabIndex = 4;
            this.txtSearchbar.Text = "Search here";
            this.txtSearchbar.Enter += new System.EventHandler(this.txtSearchbar_Enter);
            this.txtSearchbar.Leave += new System.EventHandler(this.txtSearchbar_Leave);
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
            this.btnSearchInventory.Location = new System.Drawing.Point(790, 8);
            this.btnSearchInventory.Name = "btnSearchInventory";
            this.btnSearchInventory.Size = new System.Drawing.Size(28, 27);
            this.btnSearchInventory.TabIndex = 5;
            this.btnSearchInventory.UseVisualStyleBackColor = true;
            this.btnSearchInventory.MouseEnter += new System.EventHandler(this.btnSearchInventory_MouseEnter);
            this.btnSearchInventory.MouseLeave += new System.EventHandler(this.btnSearchInventory_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(381, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 3);
            this.panel3.TabIndex = 6;
            // 
            // pnlForSearchbar
            // 
            this.pnlForSearchbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlForSearchbar.Controls.Add(this.panel3);
            this.pnlForSearchbar.Controls.Add(this.btnSearchInventory);
            this.pnlForSearchbar.Controls.Add(this.txtSearchbar);
            this.pnlForSearchbar.Controls.Add(this.lblInventoryname);
            this.pnlForSearchbar.Controls.Add(this.btnMinimizeInventory);
            this.pnlForSearchbar.Controls.Add(this.btnCloseInventory);
            this.pnlForSearchbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForSearchbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlForSearchbar.Location = new System.Drawing.Point(0, 0);
            this.pnlForSearchbar.Name = "pnlForSearchbar";
            this.pnlForSearchbar.Size = new System.Drawing.Size(1164, 41);
            this.pnlForSearchbar.TabIndex = 3;
            this.pnlForSearchbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlForSearchbar_MouseDown);
            this.pnlForSearchbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlForSearchbar_MouseMove);
            this.pnlForSearchbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlForSearchbar_MouseUp);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.pnlGridview);
            this.Controls.Add(this.pnlProductlist);
            this.Controls.Add(this.pnlForSearchbar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.pnlProductlist.ResumeLayout(false);
            this.pnlProductlist.PerformLayout();
            this.pnlGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductdetails)).EndInit();
            this.pnlForSearchbar.ResumeLayout(false);
            this.pnlForSearchbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlProductlist;
        private System.Windows.Forms.Panel pnlGridview;
        private System.Windows.Forms.Button btnShowdetails;
        private System.Windows.Forms.Button btnCloseInventory;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Label lblInventoryname;
        private System.Windows.Forms.TextBox txtSearchbar;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlForSearchbar;
        private System.Windows.Forms.DataGridView dgvProductdetails;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.TextBox txtProductTitle;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboCategory;
    }
}