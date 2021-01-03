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
    using FluentValidation.Results;
    using GroceryShop.Entity;
    using GroceryShop.Repository;
    using GroceryShop.Validation;

    public partial class InventoryForm : Form
    {
        private Products Product { get; set; }
        private Category CategoryItem { get; set; } = new Category();
        private List<Category> CatList;
        private byte move;
        private int moveX;
        private int moveY;
        private byte visibility;
        private AdminForm A1 { get; set; }
        private ManagerForm M1 { get; set; }
        private string CurrentAppId { get; set; }

        public InventoryForm()
        {
            InitializeComponent();
        }

        public InventoryForm(AdminForm a1)
        {
            InitializeComponent();
            this.A1 = a1;
            visibility = 0;

        }

        public InventoryForm(ManagerForm m1)
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
                try
                {
                    if(!this.UpdateFillEntity())
                    return;
                    if (InventoryRepo.Update(this.Product))
                    {
                        MessageBox.Show("Product updated successfully");
                        this.PopulateGridView();
                        this.dgvProductdetails.ClearSelection();
                        this.dgvProductdetails.Refresh();
                        this.ClearInputs();
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Product couldn't be added\n" + error.Message);
                    this.ClearInputs();
                }
                this.CurrentAppId = null;

            }
            else
            {
                try
                {
                    if(!this.FillEntity())
                    return;
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
                catch (Exception error)
                {
                    MessageBox.Show("Product couldn't be added\n" + error.Message);
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
            try
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
            catch
            {
                MessageBox.Show("Please insert a valid keyword");
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
                appId = CategoryRepo.SaveWithName(this.CategoryItem);

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
        private bool FillEntity()
        {
            this.Product = new Products
            {
                AppId = InventoryRepo.GetAppId(),
                Title = this.txtProductTitle.Text,
                Price = this.txtPrice.Text,
                PurchasePrice = this.txtPurchasePrice.Text,
                Quantity = this.txtQuantity.Text
            };

            if (!this.CategoryFillEntity())
                return false;

            this.Product.CategoryName = this.cboCategory.Text;
            this.Product.CategoryId = this.GetCategoryId();
            

            ProductsValidation validator = new ProductsValidation();
            ValidationResult results = validator.Validate(this.Product);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            return true;
        }

        private bool CategoryFillEntity()
        {
            this.CategoryItem.Name = this.cboCategory.Text;

            CategoryValidation validator = new CategoryValidation();
            ValidationResult results = validator.Validate(this.CategoryItem);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
        }

        private bool UpdateFillEntity()
        {
            this.Product = new Products
            {
                AppId = this.CurrentAppId,
                Title = this.txtProductTitle.Text,
                Price = this.txtPrice.Text,
                PurchasePrice = this.txtPurchasePrice.Text,
                Quantity = this.txtQuantity.Text,
                CategoryName = this.cboCategory.Text,
                CategoryId = this.GetCategoryId()
            };

            ProductsValidation validator = new ProductsValidation();
            ValidationResult results = validator.Validate(Product);
            IList<ValidationFailure> failures = results.Errors;
            if (!(results.IsValid))
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;
                }
            }
            return true;
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
            if (this.dgvProductdetails.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected");
                return;
            }

            string appId = this.dgvProductdetails.CurrentRow.Cells["appid"].Value.ToString();
            string title = this.dgvProductdetails.CurrentRow.Cells["title"].Value.ToString();

            if (MessageBox.Show($"Do you want to delete {title}?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;

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
