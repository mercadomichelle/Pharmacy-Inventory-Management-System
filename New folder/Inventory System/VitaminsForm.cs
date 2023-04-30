using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory_System
{
    public partial class VitaminsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public VitaminsForm()
        {
            InitializeComponent();
            LoadVita();
        }

        public void LoadVita()
        {
            int i = 0;
            dgvVita.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblVita", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvVita.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VitaminsModuleForm vitaModule = new VitaminsModuleForm();
            vitaModule.btnSave.Enabled = true;
            vitaModule.btnUpdate.Enabled = false;
            vitaModule.ShowDialog();
            LoadVita(); 
        }

        private void dgvVita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvVita.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                VitaminsModuleForm vitaModule = new VitaminsModuleForm();
                vitaModule.txtVitaID.Text = dgvVita.Rows[e.RowIndex].Cells[1].Value.ToString();
                vitaModule.txtBrandNameV.Text = dgvVita.Rows[e.RowIndex].Cells[2].Value.ToString();
                vitaModule.txtGenNameV.Text = dgvVita.Rows[e.RowIndex].Cells[3].Value.ToString();
                vitaModule.txtDosageV.Text = dgvVita.Rows[e.RowIndex].Cells[4].Value.ToString();
                vitaModule.txtEffectsV.Text = dgvVita.Rows[e.RowIndex].Cells[5].Value.ToString();
                vitaModule.txtMfgDateV.Text = dgvVita.Rows[e.RowIndex].Cells[6].Value.ToString();
                vitaModule.txtExpDateV.Text = dgvVita.Rows[e.RowIndex].Cells[7].Value.ToString();
                vitaModule.txtStocksV.Text = dgvVita.Rows[e.RowIndex].Cells[8].Value.ToString();

                vitaModule.btnSave.Enabled = false;
                vitaModule.btnUpdate.Enabled = true;
                vitaModule.txtVitaID.Enabled = false;
                vitaModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblVita WHERE vitaID LIKE '" + dgvVita.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadVita();
        }
    }
}
