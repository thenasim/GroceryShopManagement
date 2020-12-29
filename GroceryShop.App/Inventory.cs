﻿namespace GroceryShop.App
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

    public partial class Inventory : Form
    {
        private Products Product { get; set; }
        private InventoryRepo INRepo { get; set; }
        private CategoryRepo CatRepo { get; set; }
        private DataTable CatDt { get; set; }
        private byte move;
        private int moveX;
        private int moveY;
        public Inventory()
        {
            InitializeComponent();
            this.INRepo = new InventoryRepo();
            this.CatRepo = new CategoryRepo();
        }
        //Inventory form close
        private void btnCloseInventory_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Hover when mouse enters on close button
        private void btnCloseInventory_MouseEnter(object sender, EventArgs e)
        {
            btnCloseInventory.ForeColor = Color.Red;
        }

        //Hover when mouse leaves on close butto
        private void btnCloseInventory_MouseLeave(object sender, EventArgs e)
        {
            btnCloseInventory.ForeColor = Color.White;
        }

        //Invertory form minimize button
        private void btnMinimizeInventory_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Inventory Search button hover color when mouse enters
        private void btnSearchInventory_MouseEnter(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.SkyBlue;
        }

        //Inventory Search button hover color when mouse leaves
        private void btnSearchInventory_MouseLeave(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.White;
        }

        //search bar watermark
        private void txtSearchbar_Enter(object sender, EventArgs e)
        {
            if (txtSearchbar.Text == "Search here")
            {
                txtSearchbar.Text = "";
                txtSearchbar.ForeColor = Color.White;
            }
        }

        //Serach bar watermark
        private void txtSearchbar_Leave(object sender, EventArgs e)
        {
            if (txtSearchbar.Text == "")
            {
                txtSearchbar.Text = "Search here";
                txtSearchbar.ForeColor = Color.Gray;
            }
        }
        //Show deatails hover
        private void btnShowdetails_MouseEnter(object sender, EventArgs e)
        {
            btnShowdetails.ForeColor = Color.DeepSkyBlue;
            btnShowdetails.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }
        //show deatils hover
        private void btnShowdetails_MouseLeave(object sender, EventArgs e)
        {
            btnShowdetails.ForeColor = Color.White;
            btnShowdetails.FlatAppearance.BorderColor = Color.White;
        }

        //Add button mouse hover
        private void btnADD_MouseEnter(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.DeepSkyBlue;
            btnADD.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        //Add button mouse hover
        private void btnADD_MouseLeave(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.White;
            btnADD.FlatAppearance.BorderColor = Color.White;
        }

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearInputs();
        }

        //Clear button Hover
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Red;
            btnClear.FlatAppearance.BorderColor = Color.Red;
        }
        //clear button hover
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.White;
        }

        //To move the form around the screen
        private void pnlForSearchbar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //To move the form around the screen
        private void pnlForSearchbar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //To move the form around the screen
        private void pnlForSearchbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            this.FillEntity();
            if (InventoryRepo.Save(Product))
            {
                MessageBox.Show("Product added successfully");
                this.PopulateGridView(this.INRepo.ShowAll());
                this.ClearInputs();
            }
            else
            {
                MessageBox.Show("Product couldn't be added");
            }
        }

        //Show details button click 
        private void btnShowdetails_Click(object sender, EventArgs e)
        {
            var dt = this.INRepo.ShowAll();
            this.PopulateGridView(dt);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.dgvProductdetails.ClearSelection();
            this.dgvProductdetails.Refresh();

            try
            {
                this.CatDt = this.CatRepo.ShowAll();
                foreach (DataRow row in this.CatDt.Rows)
                {
                    this.cboCategory.Items.Add(row.Field<string>(2)); // row.Field(2) here 2 is column of category table
                }
            }
            catch(Exception error)
            {
                MessageBox.Show($"Error fetching category\n{error.Message}");
            }
        }

        /*
         * Backend Code
        */
        private void PopulateGridView(DataTable dt)
        {
            this.dgvProductdetails.AutoGenerateColumns = false;
            this.dgvProductdetails.DataSource = dt;

        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            var dt = this.INRepo.SearchInventory(this.txtSearchbar.Text);
            this.PopulateGridView(dt);
        }
        private string GetCategoryId()
        {
            if (this.cboCategory.Text == "") return "";

            string appId = "";
            foreach (DataRow row in this.CatDt.Rows)
            {
                if (row.Field<string>(2) == this.cboCategory.Text)
                    appId = row.Field<string>(1);
            }

            if (appId == "")
                appId = this.CatRepo.SaveWithName(this.cboCategory.Text);

            return appId;
        }
        private void ClearInputs()
        {
            this.txtProductTitle.Text = "";
            this.txtPrice.Text = "";
            this.txtPurchasePrice.Text = "";
            this.txtQuantity.Text = "";
            this.cboCategory.Text = "";
        }
        private void FillEntity()
        {
            this.Product = new Products();
            this.Product.AppId = this.INRepo.GetAppId();
            this.Product.Title = this.txtProductTitle.Text;
            this.Product.Price = Convert.ToDouble(this.txtPrice.Text);
            this.Product.PurchasePrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            this.Product.Quantity = Convert.ToDouble(this.txtQuantity.Text);
            this.Product.CategoryId = this.GetCategoryId();
        }
    }
}
