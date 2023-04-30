namespace Inventory_System
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ManagementSystem = new System.Windows.Forms.Label();
            this.PharmacyInventory = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.ManagementSystem);
            this.panel1.Controls.Add(this.PharmacyInventory);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(234, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // ManagementSystem
            // 
            this.ManagementSystem.AutoSize = true;
            this.ManagementSystem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagementSystem.ForeColor = System.Drawing.Color.Black;
            this.ManagementSystem.Location = new System.Drawing.Point(65, 42);
            this.ManagementSystem.Name = "ManagementSystem";
            this.ManagementSystem.Size = new System.Drawing.Size(180, 19);
            this.ManagementSystem.TabIndex = 7;
            this.ManagementSystem.Text = "MANAGEMENT SYSTEM";
            // 
            // PharmacyInventory
            // 
            this.PharmacyInventory.AutoSize = true;
            this.PharmacyInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyInventory.ForeColor = System.Drawing.Color.Black;
            this.PharmacyInventory.Location = new System.Drawing.Point(65, 23);
            this.PharmacyInventory.Name = "PharmacyInventory";
            this.PharmacyInventory.Size = new System.Drawing.Size(188, 19);
            this.PharmacyInventory.TabIndex = 6;
            this.PharmacyInventory.Text = "PHARMACY INVENTORY";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(9, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(50, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(13, 109);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(234, 23);
            this.txtUser.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(12, 89);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(71, 17);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Usename:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(12, 148);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(73, 17);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(13, 168);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(234, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Wheat;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(56, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = " Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Location = new System.Drawing.Point(145, 197);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowPass.TabIndex = 6;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 288);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label PharmacyInventory;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label ManagementSystem;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.PictureBox pictureBoxClose;
    }
}

