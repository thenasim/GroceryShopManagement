﻿namespace GroceryShop.App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportForm));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRadiobutton = new System.Windows.Forms.Panel();
            this.rdoMonthlyreport = new System.Windows.Forms.RadioButton();
            this.rdoWeeklyreport = new System.Windows.Forms.RadioButton();
            this.pnlFormbar = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnlRadiobutton.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Location = new System.Drawing.Point(368, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 525);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 456);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(633, 472);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 39);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(12, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 461);
            this.panel3.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 41);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(311, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pnlRadiobutton
            // 
            this.pnlRadiobutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRadiobutton.Controls.Add(this.rdoMonthlyreport);
            this.pnlRadiobutton.Controls.Add(this.rdoWeeklyreport);
            this.pnlRadiobutton.Location = new System.Drawing.Point(12, 65);
            this.pnlRadiobutton.Name = "pnlRadiobutton";
            this.pnlRadiobutton.Size = new System.Drawing.Size(341, 42);
            this.pnlRadiobutton.TabIndex = 7;
            // 
            // rdoMonthlyreport
            // 
            this.rdoMonthlyreport.AutoSize = true;
            this.rdoMonthlyreport.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthlyreport.ForeColor = System.Drawing.Color.White;
            this.rdoMonthlyreport.Location = new System.Drawing.Point(182, 10);
            this.rdoMonthlyreport.Name = "rdoMonthlyreport";
            this.rdoMonthlyreport.Size = new System.Drawing.Size(132, 17);
            this.rdoMonthlyreport.TabIndex = 1;
            this.rdoMonthlyreport.TabStop = true;
            this.rdoMonthlyreport.Text = "Weekly Sales report";
            this.rdoMonthlyreport.UseVisualStyleBackColor = true;
            this.rdoMonthlyreport.MouseEnter += new System.EventHandler(this.rdoMonthlyreport_MouseEnter);
            this.rdoMonthlyreport.MouseLeave += new System.EventHandler(this.rdoMonthlyreport_MouseLeave);
            // 
            // rdoWeeklyreport
            // 
            this.rdoWeeklyreport.AutoSize = true;
            this.rdoWeeklyreport.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWeeklyreport.ForeColor = System.Drawing.Color.White;
            this.rdoWeeklyreport.Location = new System.Drawing.Point(11, 10);
            this.rdoWeeklyreport.Name = "rdoWeeklyreport";
            this.rdoWeeklyreport.Size = new System.Drawing.Size(132, 17);
            this.rdoWeeklyreport.TabIndex = 0;
            this.rdoWeeklyreport.TabStop = true;
            this.rdoWeeklyreport.Text = "Weekly Sales report";
            this.rdoWeeklyreport.UseVisualStyleBackColor = true;
            this.rdoWeeklyreport.MouseEnter += new System.EventHandler(this.rdoWeeklyreport_MouseEnter);
            this.rdoWeeklyreport.MouseLeave += new System.EventHandler(this.rdoWeeklyreport_MouseLeave);
            // 
            // pnlFormbar
            // 
            this.pnlFormbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.pnlFormbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormbar.Location = new System.Drawing.Point(0, 0);
            this.pnlFormbar.Name = "pnlFormbar";
            this.pnlFormbar.Size = new System.Drawing.Size(1150, 41);
            this.pnlFormbar.TabIndex = 8;
            this.pnlFormbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFormbar_MouseDown);
            this.pnlFormbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormbar_MouseMove);
            this.pnlFormbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlFormbar_MouseUp);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1150, 602);
            this.Controls.Add(this.pnlRadiobutton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pnlFormbar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Userdetails";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnlRadiobutton.ResumeLayout(false);
            this.pnlRadiobutton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlRadiobutton;
        private System.Windows.Forms.RadioButton rdoMonthlyreport;
        private System.Windows.Forms.RadioButton rdoWeeklyreport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel pnlFormbar;
    }
}