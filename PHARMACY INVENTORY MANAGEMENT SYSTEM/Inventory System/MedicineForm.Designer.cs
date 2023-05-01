namespace Inventory_System
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Inventory_System.CustomerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMed = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Effects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MfgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageHover")));
            this.btnAdd.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageNormal")));
            this.btnAdd.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.InitialImage")));
            this.btnAdd.Location = new System.Drawing.Point(1109, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Medicine Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvMed
            // 
            this.dgvMed.AllowUserToAddRows = false;
            this.dgvMed.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMed.ColumnHeadersHeight = 30;
            this.dgvMed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.BrandName,
            this.GenName,
            this.Dosage,
            this.Effects,
            this.MfgDate,
            this.ExpDate,
            this.Stocks,
            this.Edit,
            this.Delete});
            this.dgvMed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMed.EnableHeadersVisualStyles = false;
            this.dgvMed.Location = new System.Drawing.Point(0, 0);
            this.dgvMed.Name = "dgvMed";
            this.dgvMed.Size = new System.Drawing.Size(1138, 487);
            this.dgvMed.TabIndex = 1;
            this.dgvMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMed_CellContentClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 52;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 46;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.Width = 114;
            // 
            // GenName
            // 
            this.GenName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GenName.HeaderText = "Generic Name";
            this.GenName.Name = "GenName";
            this.GenName.Width = 127;
            // 
            // Dosage
            // 
            this.Dosage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dosage.HeaderText = "Dosage";
            this.Dosage.Name = "Dosage";
            this.Dosage.Width = 83;
            // 
            // Effects
            // 
            this.Effects.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Effects.HeaderText = "Side Effects";
            this.Effects.Name = "Effects";
            this.Effects.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MfgDate
            // 
            this.MfgDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MfgDate.HeaderText = "Manufacture Date";
            this.MfgDate.Name = "MfgDate";
            this.MfgDate.Width = 151;
            // 
            // ExpDate
            // 
            this.ExpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExpDate.HeaderText = "Expiration Date";
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Width = 132;
            // 
            // Stocks
            // 
            this.Stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stocks.HeaderText = "Stocks";
            this.Stocks.Name = "Stocks";
            this.Stocks.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stocks.Width = 73;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 519);
            this.Controls.Add(this.dgvMed);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MedicineForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMed;
        private System.Windows.Forms.Label label1;
        private CustomerButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Effects;
        private System.Windows.Forms.DataGridViewTextBoxColumn MfgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stocks;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}