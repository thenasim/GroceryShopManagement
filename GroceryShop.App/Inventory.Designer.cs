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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.btnCloseInventory = new System.Windows.Forms.Button();
            this.btnMinimizeInventory = new System.Windows.Forms.Button();
            this.pnlForSearchbar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchInventory = new FontAwesome.Sharp.IconButton();
            this.txtSearchbar = new System.Windows.Forms.TextBox();
            this.lblInventoryname = new System.Windows.Forms.Label();
            this.pnlProductlist = new System.Windows.Forms.Panel();
            this.pnlGridview = new System.Windows.Forms.Panel();
            this.dgvProductdetails = new System.Windows.Forms.DataGridView();
            this.btnShowdetails = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlForSearchbar.SuspendLayout();
            this.pnlProductlist.SuspendLayout();
            this.pnlGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductdetails)).BeginInit();
            this.SuspendLayout();
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
            this.btnMinimizeInventory.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeInventory.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeInventory.Location = new System.Drawing.Point(1077, 2);
            this.btnMinimizeInventory.Name = "btnMinimizeInventory";
            this.btnMinimizeInventory.Size = new System.Drawing.Size(36, 33);
            this.btnMinimizeInventory.TabIndex = 2;
            this.btnMinimizeInventory.Text = "-";
            this.btnMinimizeInventory.UseVisualStyleBackColor = true;
            this.btnMinimizeInventory.Click += new System.EventHandler(this.btnMinimizeInventory_Click);
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
            // pnlProductlist
            // 
            this.pnlProductlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnlProductlist.Controls.Add(this.menuStrip1);
            this.pnlProductlist.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProductlist.Location = new System.Drawing.Point(0, 41);
            this.pnlProductlist.Name = "pnlProductlist";
            this.pnlProductlist.Size = new System.Drawing.Size(329, 600);
            this.pnlProductlist.TabIndex = 4;
            // 
            // pnlGridview
            // 
            this.pnlGridview.Controls.Add(this.dgvProductdetails);
            this.pnlGridview.Controls.Add(this.btnShowdetails);
            this.pnlGridview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGridview.Location = new System.Drawing.Point(324, 41);
            this.pnlGridview.Name = "pnlGridview";
            this.pnlGridview.Size = new System.Drawing.Size(840, 600);
            this.pnlGridview.TabIndex = 5;
            // 
            // dgvProductdetails
            // 
            this.dgvProductdetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.dgvProductdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductdetails.Location = new System.Drawing.Point(2, 3);
            this.dgvProductdetails.Name = "dgvProductdetails";
            this.dgvProductdetails.Size = new System.Drawing.Size(837, 497);
            this.dgvProductdetails.TabIndex = 7;
            // 
            // btnShowdetails
            // 
            this.btnShowdetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowdetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowdetails.ForeColor = System.Drawing.Color.White;
            this.btnShowdetails.Location = new System.Drawing.Point(694, 519);
            this.btnShowdetails.Name = "btnShowdetails";
            this.btnShowdetails.Size = new System.Drawing.Size(134, 42);
            this.btnShowdetails.TabIndex = 6;
            this.btnShowdetails.Text = "Show details";
            this.btnShowdetails.UseVisualStyleBackColor = true;
            this.btnShowdetails.Click += new System.EventHandler(this.btnShowdetails_Click);
            this.btnShowdetails.MouseEnter += new System.EventHandler(this.btnShowdetails_MouseEnter);
            this.btnShowdetails.MouseLeave += new System.EventHandler(this.btnShowdetails_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlForSearchbar.ResumeLayout(false);
            this.pnlForSearchbar.PerformLayout();
            this.pnlProductlist.ResumeLayout(false);
            this.pnlProductlist.PerformLayout();
            this.pnlGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseInventory;
        private System.Windows.Forms.Button btnMinimizeInventory;
        private System.Windows.Forms.Panel pnlForSearchbar;
        private System.Windows.Forms.Label lblInventoryname;
        private System.Windows.Forms.Panel pnlProductlist;
        private System.Windows.Forms.TextBox txtSearchbar;
        private FontAwesome.Sharp.IconButton btnSearchInventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlGridview;
        private System.Windows.Forms.Button btnShowdetails;
        private System.Windows.Forms.DataGridView dgvProductdetails;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}