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
using System.Data;
using System.Data.SqlClient;

namespace Project_Kel5_Manajemen_Travel
{
    public partial class Forgot_Pass : Form
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        public Forgot_Pass()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "" || repassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Text != repassword.Text)
            {
                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    String updateData = "UPDATE Staff SET password = @password WHERE username = @username";

                    using (SqlCommand cmd = new SqlCommand(updateData, connect)) 
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            FromLogin login = new FromLogin();
                            login.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error connection DataBase: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FromLogin login = new FromLogin();
            login.ShowDialog();
            this.Hide();
        }
    }
}
