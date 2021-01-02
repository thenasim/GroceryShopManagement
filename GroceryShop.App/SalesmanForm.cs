namespace GroceryShop.App
{
    using GroceryShop.Entity;
    using GroceryShop.Repository;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class SalesmanForm : Form
    {
        List<ListViewItem> cartListItems = new List<ListViewItem>();
        Products Product { get; set; } = new Products();
        Sales Sale { get; set; } = new Sales();
        double TotalPrice { get; set; } = 0;
        public bool InvalidQuantity { get; private set; } = false;

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

        //Log out button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

            LoginForm lSalesman = new LoginForm();
            lSalesman.Show();
            this.Visible = false;
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
            this.dgbShowProduct.ClearSelection();
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

        // disable the trackbar and textbox quantity
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

            // determine the tick frequency of trackbar based on what's available
            double res = quantity / 10;
            int tick = Convert.ToInt32(Math.Floor(res));
            this.trkQuantity.TickFrequency = tick;
        }

        // Add to the cart list
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (this.dgbShowProduct.CurrentRow == null)
            {
                MessageBox.Show("No row selected");
                return;
            }

            this.ValidateQuantity();

            if (String.IsNullOrEmpty(this.txtQunatity.Text) || this.InvalidQuantity)
            {
                MessageBox.Show("Quantity is not in valid range");
                return;
            }

            // Get data from datagrid view
            string title = this.dgbShowProduct.CurrentRow.Cells["title"].Value.ToString();
            string quanity = this.txtQunatity.Text;
            string productQuantity = this.dgbShowProduct.CurrentRow.Cells["quantity"].Value.ToString();
            string price = this.dgbShowProduct.CurrentRow.Cells["price"].Value.ToString();
            string appId = this.dgbShowProduct.CurrentRow.Cells["appid"].Value.ToString();

            if (this.cartListItems.Exists(item => item.SubItems[5].Text == appId)) // check if the product already added in cart list
            {
                MessageBox.Show("Already added in cart");
                return;
            }

            double totalProductPrice = Convert.ToDouble(price) * Convert.ToDouble(quanity);
            this.TotalPrice += totalProductPrice; // total price updated

            string total = Convert.ToString(totalProductPrice);

            this.lblTotalCartPrice.Text = Convert.ToString(this.TotalPrice);

            ListViewItem lvItem = new ListViewItem(title, 0); // 0
            lvItem.SubItems.Add(quanity); // 1
            lvItem.SubItems.Add(price); // 2
            lvItem.SubItems.Add(total); // 3
            lvItem.SubItems.Add(productQuantity); //  4
            lvItem.SubItems.Add(appId); // 5


            this.cartListItems.Add(lvItem); // add to the property declared in top
            this.lsvCart.Items.Add(lvItem); // add to the listView items
        }

        // Clear the cart
        private void btnClearInvoice_Click(object sender, EventArgs e)
        {
            this.cartListItems.Clear();
            this.lsvCart.Items.Clear();
            this.TotalPrice = 0;
            this.lblTotalCartPrice.Text = "0";
        }

        // Print invoice
        private async void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (this.cartListItems.Count == 0)
                return;

            try
            {
                if (MessageBox.Show("Are you sure to print?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV | *.csv ", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                            {
                                StringBuilder sb = new StringBuilder();
                                sb.AppendLine("Product Title,Price,Quantity,Total Price");

                                foreach (ListViewItem item in lsvCart.Items)
                                {
                                    sb.AppendLine(string.Format("{0},{1},{2},{3}",item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text));
                                }
                                await sw.WriteLineAsync(sb.ToString());
                                MessageBox.Show("Successfully save as text file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    this.UpdateProductsTable();
                    this.cartListItems.Clear();
                    this.lsvCart.Items.Clear();
                    this.TotalPrice = 0;
                    this.lblTotalCartPrice.Text = "0";
                    this.PopulateGridView();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error saving in database\n{error.Message}");
            }
        }

        // Update product quantity in Products table of all the cart product
        private void UpdateProductsTable()
        {
            foreach (var row in this.cartListItems)
            {
                double updatedQuantity = Convert.ToDouble(row.SubItems[4].Text) - Convert.ToDouble(row.SubItems[1].Text);
                this.FillEntity(updatedQuantity, row);
                InventoryRepo.UpdateProductQuantity(this.Product);
                SalesRepo.Save(this.Sale);
            }
        }

        // Fill the product entity
        private void FillEntity(double quantity, ListViewItem data)
        {
            string productAppId = data.SubItems[5].Text;

            this.Product.AppId = productAppId;
            this.Product.Quantity = Convert.ToString(quantity);

            this.Sale.AppId = SalesRepo.GetAppId();
            this.Sale.TotalPrice = Convert.ToDouble(data.SubItems[3].Text);
            this.Sale.Quantity = Convert.ToDouble(data.SubItems[1].Text);
            this.Sale.ProductId = productAppId;
        }

        private void ValidateQuantity()
        {
            int q; 
            if (! int.TryParse(this.txtQunatity.Text, out q))
                return;

            if (q <= this.trkQuantity.Maximum && q >= this.trkQuantity.Minimum && q != 0)
            {
                this.trkQuantity.Value = q;
                this.InvalidQuantity = false;
            }
            else
            {
                this.InvalidQuantity = true;
            }
        }

        // Trackbar Quantity updates when text Quantity changes
        private void txtQunatity_KeyUp(object sender, KeyEventArgs e)
        {
            this.ValidateQuantity();
        }

        private void SalesmanForm_Shown(object sender, EventArgs e)
        {
            this.txtSearchbar.Focus();
        }

        private void SalesmanForm_Load(object sender, EventArgs e)
        {
            this.dgbShowProduct.AutoGenerateColumns = false;
            this.dgbShowProduct.DataSource = InventoryRepo.ShowAll();
            this.dgbShowProduct.ClearSelection();
        }
    }
}
