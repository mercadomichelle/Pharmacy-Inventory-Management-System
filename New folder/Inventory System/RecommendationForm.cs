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
    public partial class RecommendationForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public RecommendationForm()
        {
            InitializeComponent();
            LoadReco();
        }

        public void LoadReco()
        {
            int i = 0;
            dgvReco.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblReco", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvReco.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RecommendationModuleForm recoModule = new RecommendationModuleForm();
            recoModule.btnSave.Enabled = true;
            recoModule.btnUpdate.Enabled = false;
            recoModule.ShowDialog();
            LoadReco();
        }

        private void dgvReco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvReco.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                RecommendationModuleForm recoModule = new RecommendationModuleForm();
                recoModule.txtRecoID.Text = dgvReco.Rows[e.RowIndex].Cells[1].Value.ToString();
                recoModule.txtMedCon.Text = dgvReco.Rows[e.RowIndex].Cells[2].Value.ToString();
                recoModule.txtAbout.Text = dgvReco.Rows[e.RowIndex].Cells[3].Value.ToString();
                recoModule.txtSymptoms.Text = dgvReco.Rows[e.RowIndex].Cells[4].Value.ToString();
                recoModule.txtMedTake.Text = dgvReco.Rows[e.RowIndex].Cells[5].Value.ToString();
                recoModule.txtMedTakeID.Text = dgvReco.Rows[e.RowIndex].Cells[6].Value.ToString();

                recoModule.btnSave.Enabled = false;
                recoModule.btnUpdate.Enabled = true;
                recoModule.txtRecoID.Enabled = false;
                recoModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblReco WHERE recoID LIKE '" + dgvReco.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadReco();
        }
    }
}
