using Project_Kel5_Manajemen_Travel.NexTrip_AdventureDataSetTableAdapters;
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
    public partial class UserTripBundleForm : UserControl
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;
        public UserTripBundleForm()
        {
            InitializeComponent();
            RefreshDataSet();
        }

        private void TripBundle_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (createPanel.Visible == true)
            {

            }
            else
            {
                btnCreate.Enabled = false;
                btnChange.Enabled = true;
                cancelBtnSearch.Enabled = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = TripBundle_gridData.Rows[e.RowIndex];

                    idTripBundle.Text = row.Cells[0].Value.ToString();
                    fillTxt.Text = row.Cells[1].Value.ToString();
                    name.Text = row.Cells[1].Value.ToString();
                    deskripsi.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        public DataSet BundleTrip()
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Paket_Trip";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Paket_Trip");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public void RefreshDataSet()
        {
            TripBundle_gridData.DataSource = BundleTrip().Tables["Paket_Trip"];
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
            lbIDCreate.Visible = true;
            btnCreate.Enabled = true;
            btnChange.Enabled = true;
        }

        public DataSet SearchTripBundle(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM Paket_Trip WHERE nama_paket LIKE @keyword OR id_paket LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "Paket_Trip");
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

            DataSet dataSet = SearchTripBundle(keyword);

            if (dataSet.Tables["Paket_Trip"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TripBundle_gridData.DataSource = dataSet.Tables["Paket_Trip"];
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string keyword = fillTxt.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keywords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataSet dataSet = SearchTripBundle(keyword);

            if (dataSet.Tables["Paket_Trip"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editPanel.Visible = true;
            lbIDCreate.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            createPanel.Visible = true;
            lbIDCreate.Visible = true;
            btnChange.Enabled = false;

            string newId = "PKT001";
            int minId = 1;
            int maxId = int.MaxValue;

            SqlCommand getIdCmd = new SqlCommand("SELECT id_paket FROM Paket_Trip", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = getIdCmd.ExecuteReader();
                List<int> existingIds = new List<int>();

                while (reader.Read())
                {
                    string currentId = reader["id_paket"].ToString();
                    int id = int.Parse(currentId.Substring(2));
                    existingIds.Add(id);
                }

                reader.Close();

                for (int i = minId; i <= maxId; i++)
                {
                    if (!existingIds.Contains(i))
                    {
                        newId = "PKT" + i.ToString().PadLeft(3, '0');
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

            insertIdTripBundle.Text = newId;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlParameter parameter = new SqlParameter();

            SqlCommand insert = new SqlCommand("sp_InputPaket", connect);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("id_paket", insertIdTripBundle.Text);
            insert.Parameters.AddWithValue("nama_paket", insertName.Text);
            insert.Parameters.AddWithValue("deskripsi_paket", insertDeskripsi.Text);

            try
            {
                connect.Open();
                insert.ExecuteNonQuery();

                MessageBox.Show("Trip Bundle create successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataSet();
                createPanel.Visible = false;
                btnChange.Enabled = true;
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
            name.Text = string.Empty;
            createPanel.Visible = false;
            btnChange.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand update = new SqlCommand("sp_UpdatePaket", connect);
                update.CommandType = CommandType.StoredProcedure;

                parameter = update.Parameters.Add("@id_paket", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = idTripBundle.Text;

                parameter = update.Parameters.Add("@nama_paket", SqlDbType.VarChar, 50);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = name.Text;

                parameter = update.Parameters.Add("@deskripsi_paket", SqlDbType.VarChar, 100);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = deskripsi.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip Bundle updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        fillTxt.Text = string.Empty;
                        editPanel.Visible = false;
                        btnChange.Enabled = true;
                        btnCreate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Trip Bundle updated failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                SqlCommand delete = new SqlCommand("sp_DeletePaket", connect);
                delete.CommandType = CommandType.StoredProcedure;

                parameter = delete.Parameters.Add("@id_paket", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = idTripBundle.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = delete.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip Bundle deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        editPanel.Visible = false;
                        btnCreate.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Trip Bundle deleted failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
