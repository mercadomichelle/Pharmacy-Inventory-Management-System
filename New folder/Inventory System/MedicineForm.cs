using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class MedicineForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public MedicineForm()
        {
            InitializeComponent();
            LoadMed();
        }

        public void LoadMed()
        { 
            int i = 0;  
            dgvMed.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblMedicine", con);  
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvMed.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MedicineModuleForm medModule = new MedicineModuleForm();
            medModule.btnSave.Enabled = true;
            medModule.btnUpdate.Enabled = false;
            medModule.ShowDialog();
            LoadMed();
        }

        private void dgvMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvMed.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                MedicineModuleForm medModule = new MedicineModuleForm();
                medModule.txtMedID.Text = dgvMed.Rows[e.RowIndex].Cells[1].Value.ToString();
                medModule.txtBrandName.Text = dgvMed.Rows[e.RowIndex].Cells[2].Value.ToString();
                medModule.txtGenName.Text = dgvMed.Rows[e.RowIndex].Cells[3].Value.ToString();
                medModule.txtDosage.Text = dgvMed.Rows[e.RowIndex].Cells[4].Value.ToString();
                medModule.txtEffects.Text = dgvMed.Rows[e.RowIndex].Cells[5].Value.ToString();
                medModule.txtMfgDate.Text = dgvMed.Rows[e.RowIndex].Cells[6].Value.ToString();
                medModule.txtExpDate.Text = dgvMed.Rows[e.RowIndex].Cells[7].Value.ToString();
                medModule.txtStocks.Text = dgvMed.Rows[e.RowIndex].Cells[8].Value.ToString();

                medModule.btnSave.Enabled = false;
                medModule.btnUpdate.Enabled = true;
                medModule.txtMedID.Enabled = false;
                medModule.ShowDialog();
                 
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();    
                    cm = new SqlCommand("DELETE FROM tblMedicine WHERE medID LIKE '" + dgvMed.Rows[e.RowIndex].Cells[1].Value.ToString() + " '", con);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadMed();
        }
    }
}
