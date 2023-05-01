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
    public partial class VitaminsModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public VitaminsModuleForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblVita(vitaID, brandNameV, genNameV, dosageV, effectsV, mfgDateV, expDateV, stocksV) VALUES(@vitaID, @brandNameV, @genNameV, @dosageV, @effectsV, @mfgDateV, @expDateV, @stocksV)", con);
                    cm.Parameters.AddWithValue("@vitaID", txtVitaID.Text);
                    cm.Parameters.AddWithValue("@brandNameV", txtBrandNameV.Text);
                    cm.Parameters.AddWithValue("@genNameV", txtGenNameV.Text);
                    cm.Parameters.AddWithValue("@dosageV", txtDosageV.Text);
                    cm.Parameters.AddWithValue("@effectsV", txtEffectsV.Text);
                    cm.Parameters.AddWithValue("@mfgDateV", txtMfgDateV.Text);
                    cm.Parameters.AddWithValue("@expDateV", txtExpDateV.Text);
                    cm.Parameters.AddWithValue("@stocksV", txtStocksV.Text);

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
            txtVitaID.Clear();
            txtBrandNameV.Clear();
            txtGenNameV.Clear();
            txtDosageV.Clear();
            txtEffectsV.Clear();
            txtMfgDateV.Clear();
            txtExpDateV.Clear();
            txtStocksV.Clear();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();  
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblVita SET brandNameV=@brandNameV, genNameV=@genNameV, dosageV=@dosageV, effectsV=@effectsV, mfgDateV=@mfgDateV, expDateV=@expDateV, stocksV=@stocksV WHERE vitaID LIKE '" + txtVitaID.Text + "' ", con);
                    cm.Parameters.AddWithValue("@brandNameV", txtBrandNameV.Text);
                    cm.Parameters.AddWithValue("@genNameV", txtGenNameV.Text);
                    cm.Parameters.AddWithValue("@dosageV", txtDosageV.Text);
                    cm.Parameters.AddWithValue("@effectsV", txtEffectsV.Text);
                    cm.Parameters.AddWithValue("@mfgDateV", txtMfgDateV.Text);
                    cm.Parameters.AddWithValue("@expDateV", txtExpDateV.Text);
                    cm.Parameters.AddWithValue("@stocksV", txtStocksV.Text);

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
