namespace GroceryShop.App
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
        private List<Category> CatList;
        private byte move;
        private int moveX;
        private int moveY;
        private byte visibility;
        private AdminForm A1 { get; set; }
        private ManagerForm M1 { get; set; }
        private string CurrentAppId { get; set; }

        public Inventory()
        {
            InitializeComponent();
        }

        public Inventory(AdminForm a1)
        {
            InitializeComponent();
            this.A1 = a1;
            visibility = 0;

        }

        public Inventory(ManagerForm m1)
        {
            InitializeComponent();
            this.M1 = m1;
            visibility = 1;
        }


        //Inventory form close
        private void btnCloseInventory_Click(object sender, EventArgs e)
        {
            if (visibility == 1)
            {
                this.Close();
                this.M1.Visible = true;
            }
            else if (visibility == 0)
            {
                this.Close();
                this.A1.Visible = true;
            }
            else
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
            txtSearchbar.Text = "Search here";
            txtSearchbar.ForeColor = Color.Gray;
            this.dgvProductdetails.DataSource = null;
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
            var idExists = InventoryRepo.SearchAppId(this.CurrentAppId);
            if (idExists)
            {
                this.UpdateFillEntity();
                if (InventoryRepo.Update(this.Product))
                {
                    MessageBox.Show("Product updated successfully");
                    this.PopulateGridView();
                    this.dgvProductdetails.ClearSelection();
                    this.dgvProductdetails.Refresh();
                    this.ClearInputs();
                }
                this.CurrentAppId = null;

            }
            else
            {
                this.FillEntity();
                if (InventoryRepo.Save(this.Product))
                {
                    MessageBox.Show("Product added successfully");
                    this.PopulateGridView();
                    this.dgvProductdetails.ClearSelection();
                    this.dgvProductdetails.Refresh();
                    this.ClearInputs();
                }
                else
                {
                    MessageBox.Show("Product couldn't be added");
                }
            }
            
 
        }

        //Show details button click 
        private void btnShowdetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvProductdetails.ClearSelection();
            this.dgvProductdetails.Refresh();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
            this.dgvProductdetails.ClearSelection();
            this.dgvProductdetails.Refresh();

            try
            {
                this.CatList = CategoryRepo.GetAll();
                foreach (var category in this.CatList)
                    this.cboCategory.Items.Add(category.Name);
            }
            catch(Exception error)
            {
                MessageBox.Show($"Error fetching category\n{error.Message}");
            }
        }
       
        /*
         * Backend Code
        */
        private void PopulateGridView()
        {
            this.dgvProductdetails.AutoGenerateColumns = false;
            this.dgvProductdetails.DataSource = InventoryRepo.ShowAll();
        }

        private void btnSearchInventory_Click(object sender, EventArgs e)
        {
            this.dgvProductdetails.AutoGenerateColumns = false;
            this.dgvProductdetails.DataSource = InventoryRepo.SearchInventory(this.txtSearchbar.Text);
            this.dgvProductdetails.ClearSelection();
            this.dgvProductdetails.Refresh();
            if (this.dgvProductdetails.RowCount == 0)
            {
                MessageBox.Show("No Data Found!");
            }
        }
        private string GetCategoryId()
        {
            string appId = "";
            foreach (var category in this.CatList)
            {
                if (category.Name == this.cboCategory.Text)
                    appId = category.AppId;
            }

            if (appId == "")
                appId = CategoryRepo.SaveWithName(this.cboCategory.Text);

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
            this.Product.AppId = InventoryRepo.GetAppId();
            this.Product.Title = this.txtProductTitle.Text;
            this.Product.Price = Convert.ToDouble(this.txtPrice.Text);
            this.Product.PurchasePrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            this.Product.Quantity = Convert.ToDouble(this.txtQuantity.Text);
            this.Product.CategoryId = this.GetCategoryId();
        }
        private void UpdateFillEntity()
        {
            this.Product = new Products();
            this.Product.AppId = this.CurrentAppId;
            this.Product.Title = this.txtProductTitle.Text;
            this.Product.Price = Convert.ToDouble(this.txtPrice.Text);
            this.Product.PurchasePrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            this.Product.Quantity = Convert.ToDouble(this.txtQuantity.Text);
            this.Product.CategoryId = this.GetCategoryId();
        }


        // Delete Hover
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
        }
        // Delete Hover
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.White;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string appId = this.dgvProductdetails.CurrentRow.Cells["appid"].Value.ToString();
            string title = this.dgvProductdetails.CurrentRow.Cells["title"].Value.ToString();
            SalesRepo.DeleteByProductId(appId);
            if (InventoryRepo.Delete(appId))
            {
                MessageBox.Show(title + " has been deleted successfully");
                this.PopulateGridView();
                this.dgvProductdetails.ClearSelection();
                this.dgvProductdetails.Refresh();
                this.ClearInputs();
            }
            else
            {
                MessageBox.Show("Product couldn't be deleted");
            }
        }

        private void dgvProductdetails_DoubleClick(object sender, EventArgs e)
        {
            this.CurrentAppId = this.dgvProductdetails.CurrentRow.Cells["appid"].Value.ToString();
            this.txtProductTitle.Text = this.dgvProductdetails.CurrentRow.Cells["title"].Value.ToString();
            this.txtPrice.Text = this.dgvProductdetails.CurrentRow.Cells["price"].Value.ToString();
            this.txtPurchasePrice.Text = this.dgvProductdetails.CurrentRow.Cells["purchase_price"].Value.ToString();
            this.cboCategory.Text = this.dgvProductdetails.CurrentRow.Cells["category_name"].Value.ToString();
            this.txtQuantity.Text = this.dgvProductdetails.CurrentRow.Cells["quantity"].Value.ToString();
        }
    }
}
