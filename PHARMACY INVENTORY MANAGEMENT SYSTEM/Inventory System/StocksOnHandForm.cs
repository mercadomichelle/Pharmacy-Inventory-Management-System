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
    public partial class StocksOnHandForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public StocksOnHandForm()
        {
            InitializeComponent();
            LoadStocks();
        }

        public void LoadStocks()
        {
            int i = 0;
            dgvStocks.Rows.Clear();
            cm = new SqlCommand("SELECT * FROM tblStocks", con);
            con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStocks.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StocksOnHandModuleForm stocksModule = new StocksOnHandModuleForm();
            stocksModule.btnSave.Enabled = true;
            stocksModule.btnUpdate.Enabled = false;
            stocksModule.ShowDialog();
            LoadStocks();
        }

        private void dgvStocks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvStocks.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                StocksOnHandModuleForm stocksModule = new StocksOnHandModuleForm();
                stocksModule.txtStocksID.Text = dgvStocks.Rows[e.RowIndex].Cells[1].Value.ToString();
                stocksModule.txtMfgDateS.Text = dgvStocks.Rows[e.RowIndex].Cells[2].Value.ToString();
                stocksModule.txtExpDateS.Text = dgvStocks.Rows[e.RowIndex].Cells[3].Value.ToString();
                stocksModule.txtMedVitaID.Text = dgvStocks.Rows[e.RowIndex].Cells[4].Value.ToString();
                stocksModule.txtStocksS.Text = dgvStocks.Rows[e.RowIndex].Cells[5].Value.ToString();

                stocksModule.btnSave.Enabled = false;
                stocksModule.btnUpdate.Enabled = true;
                stocksModule.txtStocksID.Enabled = false;
                stocksModule.ShowDialog();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cm = new SqlCommand("DELETE FROM tblStocks WHERE stocksID LIKE '" + dgvStocks.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadStocks();
        }
    }
}
