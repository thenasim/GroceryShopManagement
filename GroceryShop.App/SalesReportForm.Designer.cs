namespace GroceryShop.App
{

    partial class SalesReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.iconPictureBoxSale = new FontAwesome.Sharp.IconPictureBox();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.pnlSalesgraphs = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlComboxes = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoWeeklyreport = new System.Windows.Forms.RadioButton();
            this.pnlGridviewSalesreport = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClearSalesReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSale)).BeginInit();
            this.pnlSalesReport.SuspendLayout();
            this.pnlSalesgraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlComboxes.SuspendLayout();
            this.pnlGridviewSalesreport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1051, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 33);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1099, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.lblSalesReport);
            this.panel1.Controls.Add(this.iconPictureBoxSale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 41);
            this.panel1.TabIndex = 4;
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.ForeColor = System.Drawing.Color.White;
            this.lblSalesReport.Location = new System.Drawing.Point(47, 10);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(131, 25);
            this.lblSalesReport.TabIndex = 3;
            this.lblSalesReport.Text = "Sales Reports";
            // 
            // iconPictureBoxSale
            // 
            this.iconPictureBoxSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.iconPictureBoxSale.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconPictureBoxSale.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSale.IconSize = 37;
            this.iconPictureBoxSale.Location = new System.Drawing.Point(11, 3);
            this.iconPictureBoxSale.Name = "iconPictureBoxSale";
            this.iconPictureBoxSale.Size = new System.Drawing.Size(37, 38);
            this.iconPictureBoxSale.TabIndex = 2;
            this.iconPictureBoxSale.TabStop = false;
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pnlSalesReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesReport.Controls.Add(this.pnlSalesgraphs);
            this.pnlSalesReport.Controls.Add(this.pnlComboxes);
            this.pnlSalesReport.Controls.Add(this.pnlGridviewSalesreport);
            this.pnlSalesReport.Location = new System.Drawing.Point(0, 40);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(1139, 590);
            this.pnlSalesReport.TabIndex = 19;
            // 
            // pnlSalesgraphs
            // 
            this.pnlSalesgraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlSalesgraphs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSalesgraphs.Controls.Add(this.chart2);
            this.pnlSalesgraphs.Controls.Add(this.chart1);
            this.pnlSalesgraphs.Location = new System.Drawing.Point(11, 69);
            this.pnlSalesgraphs.Name = "pnlSalesgraphs";
            this.pnlSalesgraphs.Size = new System.Drawing.Size(312, 500);
            this.pnlSalesgraphs.TabIndex = 6;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(8, 259);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(295, 210);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(8, 14);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(295, 216);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pnlComboxes
            // 
            this.pnlComboxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComboxes.Controls.Add(this.radioButton1);
            this.pnlComboxes.Controls.Add(this.rdoWeeklyreport);
            this.pnlComboxes.Location = new System.Drawing.Point(10, 18);
            this.pnlComboxes.Name = "pnlComboxes";
            this.pnlComboxes.Size = new System.Drawing.Size(313, 44);
            this.pnlComboxes.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(153, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Monthly Sales Report";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoWeeklyreport
            // 
            this.rdoWeeklyreport.AutoSize = true;
            this.rdoWeeklyreport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeeklyreport.ForeColor = System.Drawing.Color.White;
            this.rdoWeeklyreport.Location = new System.Drawing.Point(12, 15);
            this.rdoWeeklyreport.Name = "rdoWeeklyreport";
            this.rdoWeeklyreport.Size = new System.Drawing.Size(129, 17);
            this.rdoWeeklyreport.TabIndex = 0;
            this.rdoWeeklyreport.TabStop = true;
            this.rdoWeeklyreport.Text = "Weekly Sales Report";
            this.rdoWeeklyreport.UseVisualStyleBackColor = true;
            // 
            // pnlGridviewSalesreport
            // 
            this.pnlGridviewSalesreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.pnlGridviewSalesreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridviewSalesreport.Controls.Add(this.dataGridView1);
            this.pnlGridviewSalesreport.Controls.Add(this.btnClearSalesReport);
            this.pnlGridviewSalesreport.Location = new System.Drawing.Point(340, 18);
            this.pnlGridviewSalesreport.Name = "pnlGridviewSalesreport";
            this.pnlGridviewSalesreport.Size = new System.Drawing.Size(786, 551);
            this.pnlGridviewSalesreport.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 475);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnClearSalesReport
            // 
            this.btnClearSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClearSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSalesReport.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnClearSalesReport.Location = new System.Drawing.Point(663, 504);
            this.btnClearSalesReport.Name = "btnClearSalesReport";
            this.btnClearSalesReport.Size = new System.Drawing.Size(108, 32);
            this.btnClearSalesReport.TabIndex = 19;
            this.btnClearSalesReport.Text = "CLEAR";
            this.btnClearSalesReport.UseVisualStyleBackColor = true;
            this.btnClearSalesReport.MouseEnter += new System.EventHandler(this.btnClearSalesReport_MouseEnter);
            this.btnClearSalesReport.MouseLeave += new System.EventHandler(this.btnClearSalesReport_MouseLeave);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1139, 632);
            this.Controls.Add(this.pnlSalesReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userdetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSale)).EndInit();
            this.pnlSalesReport.ResumeLayout(false);
            this.pnlSalesgraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlComboxes.ResumeLayout(false);
            this.pnlComboxes.PerformLayout();
            this.pnlGridviewSalesreport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSalesReport;
        private System.Windows.Forms.Panel pnlSalesgraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlComboxes;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdoWeeklyreport;
        private System.Windows.Forms.Panel pnlGridviewSalesreport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClearSalesReport;
        private System.Windows.Forms.Label lblSalesReport;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSale;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}