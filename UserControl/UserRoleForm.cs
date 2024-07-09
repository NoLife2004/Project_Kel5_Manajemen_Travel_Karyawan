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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Kel5_Manajemen_Travel
{
    public partial class UserRoleForm : UserControl
    {  
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;
        public UserRoleForm()
        {
            InitializeComponent();
            RefreshDataSet();
        }

        private void employee_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (createPanel.Visible == true)
            {
                
            }
            else
            {
                creatBtn.Enabled = false;
                changeBtn.Enabled = true;
                cancelBtnSearch.Enabled = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = employee_gridData.Rows[e.RowIndex];

                    if (e.ColumnIndex == 0)
                    {
                        fillTxt.Text = row.Cells[e.ColumnIndex].Value.ToString();
                    }
                    else if (e.ColumnIndex == 1)
                    {                      
                        fillTxt.Text = row.Cells[e.ColumnIndex].Value.ToString();
                    }

                    idRole.Text = row.Cells[0].Value.ToString();
                    name.Text = row.Cells[1].Value.ToString();
                }
            }

        }

        public DataSet Role()
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Role";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Role");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public void RefreshDataSet()
        {
            employee_gridData.DataSource = Role().Tables["Role"];
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataSet();
            editPanel.Visible = false;
        }

        private void cancelBtnSearch_Click(object sender, EventArgs e)
        {
            RefreshDataSet();
            fillTxt.Text = string.Empty;
            editPanel.Visible = false;
            createPanel.Visible = false;
            label5.Visible = true;
            creatBtn.Enabled = true;
            changeBtn.Enabled = true;
        }

        public DataSet SearchRolebyId(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Role WHERE id_role LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Role");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public DataSet SearchRole(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Role WHERE nama_role LIKE @keyword OR id_role LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Role");
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

            DataSet dataSet = SearchRole(keyword);

            if (dataSet.Tables["Role"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employee_gridData.DataSource = dataSet.Tables["Role"];
        }


        private void changeBtn_Click(object sender, EventArgs e)
        {
            string keyword = fillTxt.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keywords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataSet = SearchRole(keyword);

            if (dataSet.Tables["Role"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editPanel.Visible = true;
            label5.Visible = false;

        }

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == "")
            {
                createPanel.Visible = true;
                label5.Visible = false;
                changeBtn.Enabled = false;

                string newId = "RL001";
                int minId = 1;
                int maxId = int.MaxValue;

                SqlCommand getIdCmd = new SqlCommand("SELECT id_role FROM Role", connect);
                try
                {
                    connect.Open();
                    SqlDataReader reader = getIdCmd.ExecuteReader();
                    List<int> existingIds = new List<int>();

                    while (reader.Read())
                    {
                        string currentId = reader["id_role"].ToString();
                        int id = int.Parse(currentId.Substring(2));
                        existingIds.Add(id);
                    }

                    reader.Close();

                    for (int i = minId; i <= maxId; i++)
                    {
                        if (!existingIds.Contains(i))
                        {
                            newId = "RL" + i.ToString().PadLeft(3, '0');
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating new ID: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

                insertId.Text = newId;
            }
            else
            {
                
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter parameter = new SqlParameter();

            SqlCommand insert = new SqlCommand("sp_InputRole", connect);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_role", insertId.Text);
            insert.Parameters.AddWithValue("nama_role", insertName.Text);

            try
            {
                if (insertName.Text == "")
                {
                    MessageBox.Show("Please fill the name of role!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connect.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Role create successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    createPanel.Visible = false;
                    changeBtn.Enabled = true;
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

        private void cancelCreate_Click(object sender, EventArgs e)
        {
            insertName.Text = string.Empty;
            createPanel.Visible = false;
            changeBtn.Enabled = true;
            label5.Visible = true;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand update = new SqlCommand("sp_UpdateRole", connect);
                update.CommandType = CommandType.StoredProcedure;

                parameter = update.Parameters.Add("@id_role", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = idRole.Text;

                parameter = update.Parameters.Add("@nama_role", SqlDbType.VarChar, 50);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = name.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Role updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        fillTxt.Text = string.Empty;
                        editPanel.Visible = false;
                        changeBtn.Enabled = true;
                        creatBtn.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Role updated failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter parameter = new SqlParameter();

            SqlCommand delete = new SqlCommand("sp_DeleteRole", connect);
            delete.CommandType = CommandType.StoredProcedure;

            parameter = delete.Parameters.Add("@id_role", SqlDbType.VarChar, 10);
            parameter.Direction = ParameterDirection.Input;
            parameter.Value = idRole.Text;

            try
            {
                connect.Open();
                int rowsAffected = delete.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Role deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    editPanel.Visible = false;
                    creatBtn.Enabled = true;
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

        private void cancelEdit_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            editPanel.Visible = false;
            creatBtn.Enabled = true;
            label5.Visible = true;
        }

        private void insertName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
