namespace Inventory_System
{
    partial class RecommendationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecommendationForm));
            this.dgvReco = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.about = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptoms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medTake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medTakeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReco)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReco
            // 
            this.dgvReco.AllowUserToAddRows = false;
            this.dgvReco.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReco.ColumnHeadersHeight = 30;
            this.dgvReco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.recoID,
            this.MedCon,
            this.about,
            this.symptoms,
            this.medTake,
            this.medTakeID,
            this.Edit,
            this.Delete});
            this.dgvReco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReco.EnableHeadersVisualStyles = false;
            this.dgvReco.Location = new System.Drawing.Point(0, 0);
            this.dgvReco.Name = "dgvReco";
            this.dgvReco.Size = new System.Drawing.Size(1138, 487);
            this.dgvReco.TabIndex = 7;
            this.dgvReco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReco_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 32);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Recommendation Information";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 3234;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 52;
            // 
            // recoID
            // 
            this.recoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recoID.HeaderText = "Recommendation ID";
            this.recoID.Name = "recoID";
            this.recoID.Width = 168;
            // 
            // MedCon
            // 
            this.MedCon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MedCon.HeaderText = "Medical Condition";
            this.MedCon.Name = "MedCon";
            this.MedCon.Width = 153;
            // 
            // about
            // 
            this.about.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.about.HeaderText = "About/Details";
            this.about.Name = "about";
            this.about.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.about.Width = 122;
            // 
            // symptoms
            // 
            this.symptoms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.symptoms.HeaderText = "Symptoms";
            this.symptoms.Name = "symptoms";
            this.symptoms.Width = 99;
            // 
            // medTake
            // 
            this.medTake.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.medTake.HeaderText = "Medicine or vitamins to be take";
            this.medTake.Name = "medTake";
            // 
            // medTakeID
            // 
            this.medTakeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.medTakeID.HeaderText = "Medicine/Vitamins ID";
            this.medTakeID.Name = "medTakeID";
            this.medTakeID.Width = 169;
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
            // RecommendationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 519);
            this.Controls.Add(this.dgvReco);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RecommendationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecommendationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReco)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReco;
        private System.Windows.Forms.Panel panel1;
        private CustomerButton btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedCon;
        private System.Windows.Forms.DataGridViewTextBoxColumn about;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn medTake;
        private System.Windows.Forms.DataGridViewTextBoxColumn medTakeID;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}