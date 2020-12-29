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
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSaleReport = new System.Windows.Forms.Button();
            this.iconPictureBoxSalesReport = new FontAwesome.Sharp.IconPictureBox();
            this.btnMangeSalesmen = new System.Windows.Forms.Button();
            this.iconPictureBoxManageSalesmen = new FontAwesome.Sharp.IconPictureBox();
            this.btnManageCarts = new System.Windows.Forms.Button();
            this.iconPictureBoxManageCarts = new FontAwesome.Sharp.IconPictureBox();
            this.pnlManageCarts = new System.Windows.Forms.Panel();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.iconPictureBoxCarts = new FontAwesome.Sharp.IconPictureBox();
            this.pnlToMoveForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageSalesmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).BeginInit();
            this.pnlManageCarts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCarts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToMoveForm
            // 
            this.pnlToMoveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(64)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(950, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 609);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(30, 527);
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
            this.btnSaleReport.Location = new System.Drawing.Point(12, 161);
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
            this.iconPictureBoxSalesReport.Location = new System.Drawing.Point(68, 100);
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
            this.btnMangeSalesmen.Location = new System.Drawing.Point(12, 551);
            this.btnMangeSalesmen.Name = "btnMangeSalesmen";
            this.btnMangeSalesmen.Size = new System.Drawing.Size(182, 80);
            this.btnMangeSalesmen.TabIndex = 19;
            this.btnMangeSalesmen.Text = "Manage Salesmen";
            this.btnMangeSalesmen.UseVisualStyleBackColor = true;
            this.btnMangeSalesmen.MouseEnter += new System.EventHandler(this.btnMangeSalesmen_MouseEnter);
            this.btnMangeSalesmen.MouseLeave += new System.EventHandler(this.btnMangeSalesmen_MouseLeave);
            // 
            // iconPictureBoxManageSalesmen
            // 
            this.iconPictureBoxManageSalesmen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageSalesmen.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBoxManageSalesmen.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageSalesmen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageSalesmen.IconSize = 64;
            this.iconPictureBoxManageSalesmen.Location = new System.Drawing.Point(68, 491);
            this.iconPictureBoxManageSalesmen.Name = "iconPictureBoxManageSalesmen";
            this.iconPictureBoxManageSalesmen.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxManageSalesmen.TabIndex = 18;
            this.iconPictureBoxManageSalesmen.TabStop = false;
            // 
            // btnManageCarts
            // 
            this.btnManageCarts.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageCarts.FlatAppearance.BorderSize = 2;
            this.btnManageCarts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCarts.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCarts.ForeColor = System.Drawing.Color.White;
            this.btnManageCarts.Location = new System.Drawing.Point(12, 368);
            this.btnManageCarts.Name = "btnManageCarts";
            this.btnManageCarts.Size = new System.Drawing.Size(182, 40);
            this.btnManageCarts.TabIndex = 21;
            this.btnManageCarts.Text = "Manage Carts";
            this.btnManageCarts.UseVisualStyleBackColor = true;
            this.btnManageCarts.MouseEnter += new System.EventHandler(this.btnManageCarts_MouseEnter);
            this.btnManageCarts.MouseLeave += new System.EventHandler(this.btnManageCarts_MouseLeave);
            // 
            // iconPictureBoxManageCarts
            // 
            this.iconPictureBoxManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxManageCarts.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBoxManageCarts.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxManageCarts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxManageCarts.IconSize = 64;
            this.iconPictureBoxManageCarts.Location = new System.Drawing.Point(68, 308);
            this.iconPictureBoxManageCarts.Name = "iconPictureBoxManageCarts";
            this.iconPictureBoxManageCarts.Size = new System.Drawing.Size(65, 64);
            this.iconPictureBoxManageCarts.TabIndex = 20;
            this.iconPictureBoxManageCarts.TabStop = false;
            // 
            // pnlManageCarts
            // 
            this.pnlManageCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlManageCarts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlManageCarts.Controls.Add(this.lblManageUsers);
            this.pnlManageCarts.Controls.Add(this.iconPictureBoxCarts);
            this.pnlManageCarts.Location = new System.Drawing.Point(217, 49);
            this.pnlManageCarts.Name = "pnlManageCarts";
            this.pnlManageCarts.Size = new System.Drawing.Size(722, 591);
            this.pnlManageCarts.TabIndex = 22;
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.ForeColor = System.Drawing.Color.White;
            this.lblManageUsers.Location = new System.Drawing.Point(58, 17);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(54, 30);
            this.lblManageUsers.TabIndex = 1;
            this.lblManageUsers.Text = "Cart";
            // 
            // iconPictureBoxCarts
            // 
            this.iconPictureBoxCarts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.iconPictureBoxCarts.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconPictureBoxCarts.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxCarts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCarts.IconSize = 42;
            this.iconPictureBoxCarts.Location = new System.Drawing.Point(18, 13);
            this.iconPictureBoxCarts.Name = "iconPictureBoxCarts";
            this.iconPictureBoxCarts.Size = new System.Drawing.Size(50, 42);
            this.iconPictureBoxCarts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxCarts.TabIndex = 0;
            this.iconPictureBoxCarts.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pnlManageCarts);
            this.Controls.Add(this.btnManageCarts);
            this.Controls.Add(this.iconPictureBoxManageCarts);
            this.Controls.Add(this.btnMangeSalesmen);
            this.Controls.Add(this.iconPictureBoxManageSalesmen);
            this.Controls.Add(this.btnSaleReport);
            this.Controls.Add(this.iconPictureBoxSalesReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlToMoveForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.pnlToMoveForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageSalesmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxManageCarts)).EndInit();
            this.pnlManageCarts.ResumeLayout(false);
            this.pnlManageCarts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCarts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToMoveForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSaleReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSalesReport;
        private System.Windows.Forms.Button btnMangeSalesmen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageSalesmen;
        private System.Windows.Forms.Button btnManageCarts;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxManageCarts;
        private System.Windows.Forms.Panel pnlManageCarts;
        private System.Windows.Forms.Label lblManageUsers;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCarts;
    }
}