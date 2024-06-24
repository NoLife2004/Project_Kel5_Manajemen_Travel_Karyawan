using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Project_Kel5_Manajemen_Travel
{
    public partial class UserEmployeeForm : UserControl
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;
        public UserEmployeeForm()
        {
            InitializeComponent();

            RefreshDataSet();
        }

        private void UserEmployeeForm_Load(object sender, EventArgs e)
        {
            cbxRole.DisplayMember = "nama_role";
            cbxRole.ValueMember = "id_role";

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_role, nama_role FROM Role", connect);
            DataTable RoleTable = new DataTable();
            adapter.Fill(RoleTable);
            cbxRole.DataSource = RoleTable;
        }

        private void employee_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(panelEditCreate.Visible == true)
            {

            }
            else
            {
                create.Enabled = false;
                delete.Enabled = true;
                change.Enabled = true;
                cancelBtnSearch.Enabled = true;
                
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = employee_gridData.Rows[e.RowIndex];

                    lbID.Text = row.Cells[0].Value.ToString();
                    fillTxt.Text = row.Cells[2].Value.ToString();
                    name.Text = row.Cells[2].Value.ToString();
                    email.Text = row.Cells[3].Value.ToString();
                    phone.Text = row.Cells[4].Value.ToString();
                    cbxRole.SelectedValue = row.Cells[1].Value.ToString();   
                    username.Text = row.Cells[5].Value.ToString();
                    password.Text = row.Cells[6].Value.ToString();
                }
            }
        }

        public DataSet Employee()
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Staff";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public void RefreshDataSet()
        {
            employee_gridData.DataSource = Employee().Tables["Staff"];
        }

        public DataSet SearchEmployee(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Staff WHERE nama_staff LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Staff");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string keyword = fillTxt.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keywords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataSet = SearchEmployee(keyword);

            if (dataSet.Tables["Staff"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employee_gridData.DataSource = dataSet.Tables["Staff"];
        }

        private void cancelBtnSearch_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            email.Text = string.Empty;
            phone.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
            panelEditCreate.Visible = false;
            fillTxt.Text = string.Empty;
            create.Enabled = true;
            RefreshDataSet();
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == string.Empty)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelEditCreate.Visible = true;
            username.Enabled = false; 
            password.Enabled = false;
            creatBtn.Visible = false;
            updateBtn.Visible = true;
            lbEdit.Visible = true;
            lbCreate.Visible = false;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand delete = new SqlCommand("sp_DeleteStaff", connect);
                delete.CommandType = CommandType.StoredProcedure;

                parameter = delete.Parameters.Add("@id_staff", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = lbID;

                try
                {
                    connect.Open();
                    int rowsAffected = delete.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Role deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        panelEditCreate.Visible = false;
                        create.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Role deleted failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void create_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == "")
            {
                panelEditCreate.Visible = true;
                updateBtn.Visible = false;
                creatBtn.Visible = true;
                lbCreate.Visible = true;
                lbEdit.Visible = false;

                SqlCommand getIdCmd = new SqlCommand("SELECT id_staff FROM Staff", connect);
                string newId = "ST001";
                try
                {
                    connect.Open();
                    object result = getIdCmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        string currentId = result.ToString();
                        int digit = int.Parse(currentId.Substring(3));
                        digit++;
                        newId = "ST" + digit.ToString().PadLeft(3, '0');
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error executing stored procedure: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating new ID: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

                lbID.Text = newId;
            }
            else
            {
                
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            email.Text = string.Empty;
            phone.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
            panelEditCreate.Visible = false;
            create.Enabled = true;
            fillTxt.Text = string.Empty;
        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || email.Text == "" || phone.Text == "" || username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand insert = new SqlCommand("sp_InputStaff", connect);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_staff", lbID.Text);
                insert.Parameters.AddWithValue("id_role", cbxRole.SelectedValue);
                insert.Parameters.AddWithValue("nama_staff", name.Text);
                insert.Parameters.AddWithValue("email", email.Text);
                insert.Parameters.AddWithValue("no_telp", phone.Text);
                insert.Parameters.AddWithValue("username", username.Text);
                insert.Parameters.AddWithValue("password", password.Text);

                try
                {
                    connect.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Customer create successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    panelEditCreate.Visible = false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error executing stored procedure: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == "" || name.Text == "" || email.Text == "" || phone.Text == "" )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand update = new SqlCommand("sp_UpdateStaff", connect);
                update.CommandType = CommandType.StoredProcedure;

                parameter = update.Parameters.Add("@id_staff", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = lbID.Text;

                parameter = update.Parameters.Add("@id_role", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = cbxRole.SelectedValue;

                parameter = update.Parameters.Add("@nama_staff", SqlDbType.VarChar, 50);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = name.Text;

                parameter = update.Parameters.Add("@email", SqlDbType.VarChar, 25);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = email.Text;

                parameter = update.Parameters.Add("@no_telp", SqlDbType.VarChar, 13);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = phone.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Role updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        fillTxt.Text = string.Empty;
                        panelEditCreate.Visible = false;
                        create.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Role updated failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error executing stored procedure: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool emailValidate()
        {
            string regexPatern = @"^[a-zA-z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-z-A-Z]{2,4}$";
            Regex regex = new Regex(regexPatern);

            if (regex.IsMatch(email.Text))
                return true;
            else
                return false;
        }
        private void email_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl == cancelBtn)
            {
                return;
            }
            if (emailValidate() == false)
            {
                MessageBox.Show("Invalid E-mail address!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
