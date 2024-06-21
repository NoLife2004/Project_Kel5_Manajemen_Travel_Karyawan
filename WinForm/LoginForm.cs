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

namespace Project_Kel5_Manajemen_Travel
{
    public partial class FromLogin : Form
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        public FromLogin()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                try
                {
                    connect.Open();

                    String selectData = "SELECT * FROM Staff WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        cmd.Parameters.AddWithValue ("@password", password.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            MainForm afterLoginForm = new MainForm();
                            afterLoginForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connection DataBase: " + ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lnklblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgot_Pass forgot_Pass = new Forgot_Pass();
            forgot_Pass.ShowDialog();
            this.Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
                password.PasswordChar = '\0';
            }
            else
            {
                password.UseSystemPasswordChar= true;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            if (showPass.Checked == true)
            {
                password.UseSystemPasswordChar = false;
                password.PasswordChar = '\0';
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
