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
    public partial class RecommendationModuleForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\63936\Documents\Database.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public RecommendationModuleForm()
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
                    cm = new SqlCommand("INSERT INTO tblReco(RecoID, medCon, about, symptoms, medTake, medTakeID) VALUES(@recoID, @medCon, @about, @symptoms, @medTake, @medTakeID)", con);
                    cm.Parameters.AddWithValue("@recoID", txtRecoID.Text);
                    cm.Parameters.AddWithValue("@medCon", txtMedCon.Text);
                    cm.Parameters.AddWithValue("@about", txtAbout.Text);
                    cm.Parameters.AddWithValue("@symptoms", txtSymptoms.Text);
                    cm.Parameters.AddWithValue("@medTake", txtMedTake.Text);
                    cm.Parameters.AddWithValue("@medTakeID", txtMedTakeID.Text);

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
            txtRecoID.Clear();
            txtMedCon.Clear();
            txtAbout.Clear();   
            txtSymptoms.Clear();
            txtMedTake.Clear();
            txtMedTakeID.Clear();
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
                    cm = new SqlCommand("UPDATE tblReco SET medCon=@medCon, about=@about, symptoms=@symptoms, medTake=@medTake, medTakeID=@medTakeID WHERE recoID LIKE '" + txtRecoID.Text + "' ", con);
                    cm.Parameters.AddWithValue("@recoID", txtRecoID.Text);
                    cm.Parameters.AddWithValue("@medCon", txtMedCon.Text);
                    cm.Parameters.AddWithValue("@about", txtAbout.Text);
                    cm.Parameters.AddWithValue("@symptoms", txtSymptoms.Text);
                    cm.Parameters.AddWithValue("@medTake", txtMedTake.Text);
                    cm.Parameters.AddWithValue("@medTakeID", txtMedTakeID.Text);

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
