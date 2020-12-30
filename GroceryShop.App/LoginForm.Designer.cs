
namespace GroceryShop.App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnCloseLogIn = new System.Windows.Forms.Button();
            this.btnMinimizeLogIn = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlLoginLogo = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.iconPictureBoxUsername = new FontAwesome.Sharp.IconPictureBox();
            this.pnlForUsernameUnderline = new System.Windows.Forms.Panel();
            this.pnlForPasswordUnderline = new System.Windows.Forms.Panel();
            this.iconPictureBoxPassword = new FontAwesome.Sharp.IconPictureBox();
            this.pnlToMoveTheForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPassword)).BeginInit();
            this.pnlToMoveTheForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseLogIn
            // 
            this.btnCloseLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnCloseLogIn.FlatAppearance.BorderSize = 0;
            this.btnCloseLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLogIn.ForeColor = System.Drawing.Color.White;
            this.btnCloseLogIn.Location = new System.Drawing.Point(363, 3);
            this.btnCloseLogIn.Name = "btnCloseLogIn";
            this.btnCloseLogIn.Size = new System.Drawing.Size(34, 33);
            this.btnCloseLogIn.TabIndex = 0;
            this.btnCloseLogIn.Text = "X";
            this.btnCloseLogIn.UseVisualStyleBackColor = true;
            this.btnCloseLogIn.Click += new System.EventHandler(this.btnCloseLogIn_Click);
            this.btnCloseLogIn.MouseEnter += new System.EventHandler(this.btnCloseLogIn_MouseEnter);
            this.btnCloseLogIn.MouseLeave += new System.EventHandler(this.btnCloseLogIn_MouseLeave);
            // 
            // btnMinimizeLogIn
            // 
            this.btnMinimizeLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnMinimizeLogIn.FlatAppearance.BorderSize = 0;
            this.btnMinimizeLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeLogIn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeLogIn.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeLogIn.Location = new System.Drawing.Point(316, 2);
            this.btnMinimizeLogIn.Name = "btnMinimizeLogIn";
            this.btnMinimizeLogIn.Size = new System.Drawing.Size(36, 33);
            this.btnMinimizeLogIn.TabIndex = 1;
            this.btnMinimizeLogIn.Text = "-";
            this.btnMinimizeLogIn.UseVisualStyleBackColor = true;
            this.btnMinimizeLogIn.Click += new System.EventHandler(this.btnMinimizeLogIn_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(117, 253);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 27);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(117, 334);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pnlLoginLogo
            // 
            this.pnlLoginLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoginLogo.BackgroundImage")));
            this.pnlLoginLogo.Location = new System.Drawing.Point(4, 55);
            this.pnlLoginLogo.Name = "pnlLoginLogo";
            this.pnlLoginLogo.Size = new System.Drawing.Size(391, 162);
            this.pnlLoginLogo.TabIndex = 4;
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(146, 422);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(132, 49);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            this.btnLogIn.MouseEnter += new System.EventHandler(this.btnLogIn_MouseEnter);
            this.btnLogIn.MouseLeave += new System.EventHandler(this.btnLogIn_MouseLeave);
            // 
            // iconPictureBoxUsername
            // 
            this.iconPictureBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxUsername.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBoxUsername.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUsername.IconSize = 36;
            this.iconPictureBoxUsername.Location = new System.Drawing.Point(75, 251);
            this.iconPictureBoxUsername.Name = "iconPictureBoxUsername";
            this.iconPictureBoxUsername.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBoxUsername.TabIndex = 6;
            this.iconPictureBoxUsername.TabStop = false;
            // 
            // pnlForUsernameUnderline
            // 
            this.pnlForUsernameUnderline.BackColor = System.Drawing.Color.White;
            this.pnlForUsernameUnderline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForUsernameUnderline.ForeColor = System.Drawing.Color.White;
            this.pnlForUsernameUnderline.Location = new System.Drawing.Point(117, 281);
            this.pnlForUsernameUnderline.Name = "pnlForUsernameUnderline";
            this.pnlForUsernameUnderline.Size = new System.Drawing.Size(197, 3);
            this.pnlForUsernameUnderline.TabIndex = 7;
            // 
            // pnlForPasswordUnderline
            // 
            this.pnlForPasswordUnderline.BackColor = System.Drawing.Color.White;
            this.pnlForPasswordUnderline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForPasswordUnderline.ForeColor = System.Drawing.Color.White;
            this.pnlForPasswordUnderline.Location = new System.Drawing.Point(118, 359);
            this.pnlForPasswordUnderline.Name = "pnlForPasswordUnderline";
            this.pnlForPasswordUnderline.Size = new System.Drawing.Size(197, 3);
            this.pnlForPasswordUnderline.TabIndex = 8;
            // 
            // iconPictureBoxPassword
            // 
            this.iconPictureBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.iconPictureBoxPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBoxPassword.IconColor = System.Drawing.Color.White;
            this.iconPictureBoxPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxPassword.IconSize = 36;
            this.iconPictureBoxPassword.Location = new System.Drawing.Point(76, 326);
            this.iconPictureBoxPassword.Name = "iconPictureBoxPassword";
            this.iconPictureBoxPassword.Size = new System.Drawing.Size(36, 36);
            this.iconPictureBoxPassword.TabIndex = 9;
            this.iconPictureBoxPassword.TabStop = false;
            // 
            // pnlToMoveTheForm
            // 
            this.pnlToMoveTheForm.Controls.Add(this.btnCloseLogIn);
            this.pnlToMoveTheForm.Controls.Add(this.btnMinimizeLogIn);
            this.pnlToMoveTheForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToMoveTheForm.Location = new System.Drawing.Point(0, 0);
            this.pnlToMoveTheForm.Name = "pnlToMoveTheForm";
            this.pnlToMoveTheForm.Size = new System.Drawing.Size(400, 35);
            this.pnlToMoveTheForm.TabIndex = 10;
            this.pnlToMoveTheForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveTheForm_MouseDown);
            this.pnlToMoveTheForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveTheForm_MouseMove);
            this.pnlToMoveTheForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlToMoveTheForm_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.pnlToMoveTheForm);
            this.Controls.Add(this.iconPictureBoxPassword);
            this.Controls.Add(this.pnlForPasswordUnderline);
            this.Controls.Add(this.pnlForUsernameUnderline);
            this.Controls.Add(this.iconPictureBoxUsername);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pnlLoginLogo);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxPassword)).EndInit();
            this.pnlToMoveTheForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseLogIn;
        private System.Windows.Forms.Button btnMinimizeLogIn;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlLoginLogo;
        private System.Windows.Forms.Button btnLogIn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUsername;
        private System.Windows.Forms.Panel pnlForUsernameUnderline;
        private System.Windows.Forms.Panel pnlForPasswordUnderline;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxPassword;
        private System.Windows.Forms.Panel pnlToMoveTheForm;
    }
}

