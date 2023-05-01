namespace Inventory_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerButton1 = new Inventory_System.CustomerButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.PharmacyInventoryManagementSystem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnStock = new Inventory_System.CustomerButton();
            this.btnReco = new Inventory_System.CustomerButton();
            this.btnMed = new Inventory_System.CustomerButton();
            this.btnVita = new Inventory_System.CustomerButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVita)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.customerButton1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Controls.Add(this.PharmacyInventoryManagementSystem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 74);
            this.panel1.TabIndex = 0;
            // 
            // customerButton1
            // 
            this.customerButton1.Image = ((System.Drawing.Image)(resources.GetObject("customerButton1.Image")));
            this.customerButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageHover")));
            this.customerButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customerButton1.ImageNormal")));
            this.customerButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("customerButton1.InitialImage")));
            this.customerButton1.Location = new System.Drawing.Point(1184, 17);
            this.customerButton1.Name = "customerButton1";
            this.customerButton1.Size = new System.Drawing.Size(34, 29);
            this.customerButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customerButton1.TabIndex = 12;
            this.customerButton1.TabStop = false;
            this.customerButton1.Click += new System.EventHandler(this.customerButton1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1185, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(91, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "MD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(62, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 31);
            this.label10.TabIndex = 10;
            this.label10.Text = "System";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(12, 11);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(50, 50);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // PharmacyInventoryManagementSystem
            // 
            this.PharmacyInventoryManagementSystem.AutoSize = true;
            this.PharmacyInventoryManagementSystem.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PharmacyInventoryManagementSystem.ForeColor = System.Drawing.Color.Black;
            this.PharmacyInventoryManagementSystem.Location = new System.Drawing.Point(211, 17);
            this.PharmacyInventoryManagementSystem.Name = "PharmacyInventoryManagementSystem";
            this.PharmacyInventoryManagementSystem.Size = new System.Drawing.Size(825, 44);
            this.PharmacyInventoryManagementSystem.TabIndex = 7;
            this.PharmacyInventoryManagementSystem.Text = "PHARMACY INVENTORY MANAGEMENT SYSTEM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Medication";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Find";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Medicine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recommended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vitamins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Find";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "On Hand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 10);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(92, 73);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1138, 519);
            this.panelMain.TabIndex = 2;
            // 
            // btnStock
            // 
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageHover")));
            this.btnStock.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnStock.ImageNormal")));
            this.btnStock.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnStock.InitialImage")));
            this.btnStock.Location = new System.Drawing.Point(28, 145);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(34, 29);
            this.btnStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStock.TabIndex = 0;
            this.btnStock.TabStop = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnReco
            // 
            this.btnReco.Image = ((System.Drawing.Image)(resources.GetObject("btnReco.Image")));
            this.btnReco.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnReco.ImageHover")));
            this.btnReco.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnReco.ImageNormal")));
            this.btnReco.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnReco.InitialImage")));
            this.btnReco.Location = new System.Drawing.Point(28, 414);
            this.btnReco.Name = "btnReco";
            this.btnReco.Size = new System.Drawing.Size(34, 29);
            this.btnReco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReco.TabIndex = 3;
            this.btnReco.TabStop = false;
            this.btnReco.Click += new System.EventHandler(this.btnReco_Click);
            // 
            // btnMed
            // 
            this.btnMed.Image = ((System.Drawing.Image)(resources.GetObject("btnMed.Image")));
            this.btnMed.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnMed.ImageHover")));
            this.btnMed.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnMed.ImageNormal")));
            this.btnMed.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMed.InitialImage")));
            this.btnMed.Location = new System.Drawing.Point(28, 233);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(34, 29);
            this.btnMed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMed.TabIndex = 1;
            this.btnMed.TabStop = false;
            this.btnMed.Click += new System.EventHandler(this.customerButton2_Click);
            // 
            // btnVita
            // 
            this.btnVita.Image = ((System.Drawing.Image)(resources.GetObject("btnVita.Image")));
            this.btnVita.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnVita.ImageHover")));
            this.btnVita.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnVita.ImageNormal")));
            this.btnVita.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnVita.InitialImage")));
            this.btnVita.Location = new System.Drawing.Point(28, 319);
            this.btnVita.Name = "btnVita";
            this.btnVita.Size = new System.Drawing.Size(34, 29);
            this.btnVita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVita.TabIndex = 2;
            this.btnVita.TabStop = false;
            this.btnVita.Click += new System.EventHandler(this.btnVita_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1230, 601);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnReco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnVita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label PharmacyInventoryManagementSystem;
        private CustomerButton btnStock;
        private CustomerButton btnReco;
        private CustomerButton btnVita;
        private CustomerButton btnMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private CustomerButton customerButton1;
        private System.Windows.Forms.Label label11;
    }
}