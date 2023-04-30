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
    public partial class StocksOnHandModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();     
        
        public StocksOnHandModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblStocks(stocksID, mfgDateS, expDateS, medVitaID, stocksS) VALUES(@stocksID, @mfgDateS, @expDateS, @medVitaID, @stocksS)", con);
                    cm.Parameters.AddWithValue("@stocksID", txtStocksID.Text);
                    cm.Parameters.AddWithValue("@mfgDateS", txtMfgDateS.Text);
                    cm.Parameters.AddWithValue("@expDateS", txtExpDateS.Text);
                    cm.Parameters.AddWithValue("@medVitaID", txtMedVitaID.Text);
                    cm.Parameters.AddWithValue("@stocksS", txtStocksS.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been successfully saved.");
                    Clear();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Clear() 
        { 
            txtStocksID.Clear();
            txtMfgDateS.Clear();
            txtExpDateS.Clear();
            txtMedVitaID.Clear();
            txtStocksS.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblStocks SET mfgDateS=@mfgDateS, expDateS=@expDateS, medVitaID=@medVitaID, stocksS=@stocksS WHERE stocksID LIKE '" + txtStocksID.Text + "' ", con);
                    cm.Parameters.AddWithValue("@mfgDateS", txtMfgDateS.Text);
                    cm.Parameters.AddWithValue("@expDateS", txtExpDateS.Text);
                    cm.Parameters.AddWithValue("@medVitaID", txtMedVitaID.Text);
                    cm.Parameters.AddWithValue("@stocksS", txtStocksS.Text);
                    con.Open();
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been successfully updated!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
