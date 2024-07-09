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
    public partial class UserCustomersForm : UserControl
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;

        public UserCustomersForm()
        {
            InitializeComponent();

            RefreshDataSet();
        }

        private void customers_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (panelEditCreate.Visible == true)
            {

            }
            else
            {
                create.Enabled = false;
                delete.Enabled = true;
                change.Enabled = true;
                cancelBtnSearch.Enabled = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = customer_gridData.Rows[e.RowIndex];

                    lbID.Text = row.Cells[0].Value.ToString();
                    fillTxt.Text = row.Cells[1].Value.ToString();
                    name.Text = row.Cells[1].Value.ToString();
                    cbxGender.SelectedValue = row.Cells[2].Value.ToString();
                    address.Text = row.Cells[3].Value.ToString();
                    callNum.Text = row.Cells[4].Value.ToString();
                }
            }
        }

        public DataSet Customers()
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Customer";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public void RefreshDataSet()
        {
            customer_gridData.DataSource = Customers().Tables["Customer"];
        }

        public DataSet SearchCustomer(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Customer WHERE nama_customer LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Customer");
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

            DataSet dataSet = SearchCustomer(keyword);

            if (dataSet.Tables["Customer"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customer_gridData.DataSource = dataSet.Tables["Customer"];
        }

        private void cancelBtnSearch_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            address.Text = string.Empty;
            callNum.Text = string.Empty;
            lbID.Text = string.Empty;
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
            else
            {
                panelEditCreate.Visible = true;
                updateBtn.Visible = true;
                creatBtn.Visible = false;
                lbCreate.Visible = false;
                lbEdit.Visible = true;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (fillTxt.Text == "")
            {
                MessageBox.Show("Please fill a blank field", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand delete = new SqlCommand("sp_DeleteCustomer", connect);
                delete.CommandType = CommandType.StoredProcedure;

                parameter = delete.Parameters.Add("@id_customer", SqlDbType.VarChar, 10);
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
                        MessageBox.Show("Customer deleted failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                SqlCommand getMaxIdCmd = new SqlCommand("SELECT MAX(id_customer) FROM Customer", connect);
                string newId = "CT001";
                try
                {
                    connect.Open();
                    object result = getMaxIdCmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        string currentId = result.ToString();
                        int digit = int.Parse(currentId.Substring(3));
                        digit++;
                        newId = "CT" + digit.ToString().PadLeft(3, '0');
                    }
                    else
                    {
                        newId = "CT001";
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

        private void creatBtn_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || address.Text == "" || callNum.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand insert = new SqlCommand("sp_InputCustomer", connect);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_customer", lbID.Text);
                insert.Parameters.AddWithValue("nama_customer", name.Text);
                insert.Parameters.AddWithValue("gender", cbxGender.SelectedItem);
                insert.Parameters.AddWithValue("alamat", address.Text);
                insert.Parameters.AddWithValue("no_telp", callNum.Text);

                try
                {
                    connect.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Customer added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    panelEditCreate.Visible = false;
                    lbID.Text = string.Empty;
                    name.Text = string.Empty;
                    cbxGender.Text = string.Empty;
                    address.Text = string.Empty;
                    callNum.Text = string.Empty;
                    updateBtn.Enabled = true;
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
            if (fillTxt.Text == "" || name.Text == "" || address.Text == "" || callNum.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand update = new SqlCommand("sp_UpdateCustomer", connect);
                update.CommandType = CommandType.StoredProcedure;

                parameter = update.Parameters.Add("@id_customer", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = lbID.Text;

                parameter = update.Parameters.Add("@nama_customer", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = name.Text;

                parameter = update.Parameters.Add("@gender", SqlDbType.VarChar, 15);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = cbxGender.SelectedItem;

                parameter = update.Parameters.Add("@alamat", SqlDbType.VarChar, 25);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = address.Text;

                parameter = update.Parameters.Add("@no_telp", SqlDbType.VarChar, 25);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = callNum.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        fillTxt.Text = string.Empty;
                        panelEditCreate.Visible = false;
                        lbID.Text = string.Empty;
                        name.Text = string.Empty;
                        cbxGender.Text = string.Empty;
                        address.Text = string.Empty;
                        callNum.Text = string.Empty;
                        create.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Customer updated failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            cbxGender.Text = string.Empty;
            address.Text = string.Empty;
            callNum.Text = string.Empty;
            panelEditCreate.Visible = false;
            create.Enabled = true;
            fillTxt.Text = string.Empty;
        }

        private void callNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;    
            }
        }
    }
}
