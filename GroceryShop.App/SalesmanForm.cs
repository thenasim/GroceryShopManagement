namespace GroceryShop.App
{
    using GroceryShop.Repository;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SalesmanForm : Form
    {
        List<ListViewItem> cartListItems = new List<ListViewItem>();
        double TotalPrice { get; set; } = 0;
        private byte move;
        private int moveX;
        private int moveY;
        public SalesmanForm()
        {
            InitializeComponent();
        }

        //form close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Close Button hover color
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        //Close Button hover color
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        //Minimize button
        private void btnMinimizeInventory_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mouse hover for log out button
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.OrangeRed;
            btnLogout.FlatAppearance.BorderColor = Color.OrangeRed;

        }

        //Mouse hover for log out button
        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatAppearance.BorderColor = Color.White;

        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //To move the form all over the screen
        private void pnlToMoveForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }


        //To hide all visibility of all features panels at starting
        private void pnlEmployeeform_Paint(object sender, PaintEventArgs e)
        {
            pnlManageCarts.Visible = true;
        }

        //Search Inventory button hover color
        private void btnSearchInventory_MouseEnter(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.LightBlue;
        }

        //Search Inventory button hover color
        private void btnSearchInventory_MouseLeave(object sender, EventArgs e)
        {
            btnSearchInventory.IconColor = Color.White;
        }

        //ADD button hover color
        private void btnADD_MouseEnter(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.SkyBlue;
            btnADD.FlatAppearance.BorderColor = Color.SkyBlue;
        }

        //ADD button hover color
        private void btnADD_MouseLeave(object sender, EventArgs e)
        {
            btnADD.ForeColor = Color.White;
            btnADD.FlatAppearance.BorderColor = Color.White;
        }

        //Clear button hover color
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.Red;
            btnClear.FlatAppearance.BorderColor = Color.Red;
        }

        //Clear button hover color
        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.ForeColor = Color.White;
            btnClear.FlatAppearance.BorderColor = Color.White;
        }

        //Searchbar watermark
        private void txtSearchbar_Enter(object sender, EventArgs e)
        {
            if(txtSearchbar.Text=="Search here")
            {
                txtSearchbar.Text = "";
                txtSearchbar.ForeColor = Color.White;
            }
        }

        //Searchbar watermark
        private void txtSearchbar_Leave(object sender, EventArgs e)
        {
            if (txtSearchbar.Text == "")
            {
                txtSearchbar.Text = "Search here";
                txtSearchbar.ForeColor = Color.Gray;
            }
        }

        //Print invoice button hover color
        private void btnPrintInvoice_MouseEnter(object sender, EventArgs e)
        {
            btnPrintInvoice.ForeColor = Color.Green;
            btnPrintInvoice.FlatAppearance.BorderColor = Color.Green;
        }

        //Print invoice button hover color
        private void btnPrintInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.FlatAppearance.BorderColor = Color.White;

        }

        //Clear invoice button hover color
        private void btnClearInvoice_MouseEnter(object sender, EventArgs e)
        {
            btnClearInvoice.ForeColor = Color.Red;
            btnClearInvoice.FlatAppearance.BorderColor = Color.Red;
        }

        //Clear invoice button hover color
        private void btnClearInvoice_MouseLeave(object sender, EventArgs e)
        {
            btnClearInvoice.ForeColor = Color.White;
            btnClearInvoice.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            this.SearchInventory();
        }

        private void txtSearchbar_KeyUp(object sender, KeyEventArgs e)
        {
            this.SearchInventory();
        }

        private void PopulateGridView()
        {
            this.dgbShowProduct.AutoGenerateColumns = false;
            this.dgbShowProduct.DataSource = InventoryRepo.SearchInventory(this.txtSearchbar.Text);
        }

        private void SearchInventory()
        {
            if (String.IsNullOrEmpty(this.txtSearchbar.Text) || this.txtSearchbar.Text == "Search here")
            {
                this.dgbShowProduct.DataSource = null;
                this.dgbShowProduct.Rows.Clear();
                this.DisableAndClearQuantity();
                return;
            }
            this.PopulateGridView();
            this.dgbShowProduct.ClearSelection();
        }

        private void DisableAndClearQuantity()
        {
            this.trkQuantity.Enabled = false;
            this.txtQunatity.Enabled = false;
            this.txtQunatity.Text = "1";
            this.trkQuantity.Value = 1;
        }

        private void trkQuantity_Scroll(object sender, EventArgs e)
        {
            this.txtQunatity.Text = Convert.ToString(this.trkQuantity.Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgbShowProduct.DataSource = null;
            this.dgbShowProduct.Rows.Clear();
            this.DisableAndClearQuantity();
        }

        private void dgbShowProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int quantity = Convert.ToInt32(this.dgbShowProduct.CurrentRow.Cells["quantity"].Value.ToString());
            this.trkQuantity.Enabled = true;
            this.txtQunatity.Enabled = true;
            this.trkQuantity.Maximum = quantity;

            double res = quantity / 10;
            int tick = Convert.ToInt32(Math.Floor(res));
            this.trkQuantity.TickFrequency = tick;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (this.dgbShowProduct.CurrentRow == null)
                return;

            if (String.IsNullOrEmpty(this.txtQunatity.Text))
            {
                MessageBox.Show("Please add quantity");
                return;
            }

            string title = this.dgbShowProduct.CurrentRow.Cells["title"].Value.ToString();
            string quanity = this.txtQunatity.Text;
            string price = this.dgbShowProduct.CurrentRow.Cells["price"].Value.ToString();
            string appId = this.dgbShowProduct.CurrentRow.Cells["appid"].Value.ToString();
            double totalProductPrice = Convert.ToDouble(price) * Convert.ToDouble(quanity);
            this.TotalPrice += totalProductPrice;

            string total = Convert.ToString(totalProductPrice);

            this.lblTotalCartPrice.Text = Convert.ToString(this.TotalPrice);

            ListViewItem lvItem = new ListViewItem(title, 0);
            lvItem.SubItems.Add(quanity);
            lvItem.SubItems.Add(price);
            lvItem.SubItems.Add(total);
            lvItem.SubItems.Add(appId);

            if (this.cartListItems.Exists(item => item.SubItems[4].Text == appId))
            {
                MessageBox.Show("Already added in cart");
                return;
            }

            this.cartListItems.Add(lvItem);
            this.lsvCart.Items.Add(lvItem);
        }

        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            this.cartListItems.Clear();
            this.lsvCart.Items.Clear();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printed successfully");
        }
    }
}
