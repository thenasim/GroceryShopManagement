namespace GroceryShop.App
{
    using GroceryShop.Entity;
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

    public partial class SalesReportForm : Form
    {
        private byte move;
        private int moveX;
        private int moveY;
        private byte visibilty;

        private AdminForm A1 { get; set; }
        private ManagerForm M1 { get; set; }

        public SalesReportForm()
        {
            InitializeComponent();
        }

        public SalesReportForm(AdminForm a1)
        {
            InitializeComponent();
            this.A1 = a1;
            visibilty = 0;
        }

        public SalesReportForm(ManagerForm m1)
        {
            InitializeComponent();
            this.M1 = m1;
            visibilty = 1;
        }


        //Minimize work
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // form close
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (visibilty == 1)
            {
                this.Close();
                this.M1.Visible = true;
            }
            else if (visibilty == 0)
            {
                this.Close();
                this.A1.Visible = true;
            }
            else
                Application.Exit();
        }

        //close button hover
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }
        //close button hover
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Red;
        }

        //To move the form
        private void pnlFormbar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        //To move the form
        private void pnlFormbar_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        //To move the form
        private void pnlFormbar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            List<Sales> reports = SalesRepo.ProductSaleList();

            if (reports.Count == 0)
                return;

            foreach(Sales s in reports)
            {
                this.chartMostSoldProduct.Series["Sales"].Points.AddXY(s.Title, Convert.ToInt32(s.Quantity));
            }

            reports = SalesRepo.ProductSaleList("benefit");
            foreach(Sales s in reports)
            {
                this.chartMostBenefitProduct.Series["Benefit"].Points.AddXY(s.Title, Convert.ToInt32(s.Benefit));
            }


            try
            {
                string todayBenefit = SalesRepo.TodaysBenefit();
                
                if (todayBenefit == null)
                    this.lblTodayBenefit.Text = "0 Tk";
                else
                    this.lblTodayBenefit.Text = todayBenefit + " tk";
            }
            catch 
            {
                this.lblTodayBenefit.Text = "0 Tk";
            }

            try
            {
                string thisMonthBenefit = SalesRepo.CurrentMonthBenefit();
                
                if (thisMonthBenefit == null)
                    this.lblThisMonthBenefit.Text = "0 Tk";
                else
                    this.lblThisMonthBenefit.Text = thisMonthBenefit + " tk";
            }
            catch 
            {
                this.lblThisMonthBenefit.Text = "0 Tk";
            }
        }
    }
}
