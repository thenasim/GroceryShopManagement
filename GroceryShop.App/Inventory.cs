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

    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
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
            btnShowdetails.FlatAppearance.BorderColor= Color.DeepSkyBlue;
        }
        //show deatils hover
        private void btnShowdetails_MouseLeave(object sender, EventArgs e)
        {
            btnShowdetails.ForeColor = Color.White;
            btnShowdetails.FlatAppearance.BorderColor = Color.White;
        }
        //Show details button click 
        private void btnShowdetails_Click(object sender, EventArgs e)
        {

        }
    }
    
}
