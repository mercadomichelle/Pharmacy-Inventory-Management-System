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
    public partial class MedicineModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public MedicineModuleForm()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                if (MessageBox.Show("Are you sure you want to save this data?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO tblMedicine(medID, brandName, genName, dosage, effects, mfgDate, expDate, stocks) VALUES(@medID, @brandName, @genName, @dosage, @effects, @mfgDate, @expDate, @stocks)", con);
                    cm.Parameters.AddWithValue("@medID", txtMedID.Text);
                    cm.Parameters.AddWithValue("@brandName", txtBrandName.Text);
                    cm.Parameters.AddWithValue("@genName", txtGenName.Text);
                    cm.Parameters.AddWithValue("@dosage", txtDosage.Text);
                    cm.Parameters.AddWithValue("@effects", txtEffects.Text);
                    cm.Parameters.AddWithValue("@mfgDate", txtMfgDate.Text);
                    cm.Parameters.AddWithValue("@expDate", txtExpDate.Text);
                    cm.Parameters.AddWithValue("@stocks", txtStocks.Text);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtMedID.Clear();
            txtBrandName.Clear();
            txtGenName.Clear();
            txtDosage.Clear();
            txtEffects.Clear();
            txtMfgDate.Clear();
            txtExpDate.Clear();
            txtStocks.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this data?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tblMedicine SET brandName=@brandName, genName=@genName, dosage=@dosage, effects=@effects, mfgDate=@mfgDate, expDate=@expDate, stocks=@stocks WHERE medID LIKE '"+txtMedID.Text +"' ", con);
                    cm.Parameters.AddWithValue("@brandName", txtBrandName.Text); 
                    cm.Parameters.AddWithValue("@genName", txtGenName.Text);
                    cm.Parameters.AddWithValue("@dosage", txtDosage.Text);
                    cm.Parameters.AddWithValue("@effects", txtEffects.Text);
                    cm.Parameters.AddWithValue("@mfgDate", txtMfgDate.Text);
                    cm.Parameters.AddWithValue("@expDate", txtExpDate.Text);
                    cm.Parameters.AddWithValue("@stocks", txtStocks.Text);
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
