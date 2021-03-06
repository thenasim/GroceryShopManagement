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
    using FluentValidation.Results;
    using GroceryShop.Validation;

    public partial class CategoryForm : Form
    {
        private Category Category { get; set; }
        private string appId;
        private byte visibity;
        private byte move;
        private int moveX;
        private int moveY;
        
        private ManagerForm M1 { get; set; }
        public CategoryForm()
        {
            InitializeComponent();
        }
       
        //Manager form reference
        public CategoryForm(ManagerForm m1)
        {
            InitializeComponent();
            this.M1 = m1;
            visibity = 1;
        }

        //Minimizer button
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //close buttion
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (visibity == 1)
            {
                this.Close();
                this.M1.Visible = true;
            }
            else
                Application.Exit();
        }
        //close button hover color
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }
        //Close button hover color
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }


        //Close button hover color
        private void btnShow_MouseEnter(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.DeepSkyBlue;
            btnShow.FlatAppearance.BorderColor = Color.DeepSkyBlue;
        }

        //Close button hover color
        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.White;
            btnShow.FlatAppearance.BorderColor = Color.White;
        }

        //Close button hover color
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.LightGreen;
            btnEdit.FlatAppearance.BorderColor = Color.LightGreen;
        }

        //Close button hover color
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatAppearance.BorderColor = Color.White;
        }

        //Move the form
        private void pnlFormmove_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //Move the form
        private void pnlFormmove_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        //Move the form
        private void pnlFormmove_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (!this.UpdateFillEntity())
                    return;
                if (CategoryRepo.Update(this.Category))
                {
                    MessageBox.Show("Successfully updated  category");
                    this.PopulateGridView();
                    this.textBox1.Text = "";
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error!" + a.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            dgvCategory.DataSource = null;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private void PopulateGridView()
        {
            try
            {
                this.dgvCategory.AutoGenerateColumns = false;
                this.dgvCategory.DataSource = CategoryRepo.GetAll();
                this.dgvCategory.ClearSelection();
                this.dgvCategory.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!" + e.Message);
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
        private bool UpdateFillEntity()
        {
            this.Category = new Category
            {
                AppId = this.appId,
                Name = this.textBox1.Text
            };

            CategoryValidation validator = new CategoryValidation();
            ValidationResult results = validator.Validate(Category);
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

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            this.appId = this.dgvCategory.CurrentRow.Cells["categoryid"].Value.ToString();
            this.textBox1.Text = this.dgvCategory.CurrentRow.Cells["name"].Value.ToString();
        }
    }
}
