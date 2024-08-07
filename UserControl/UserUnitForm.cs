﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Kel5_Manajemen_Travel
{
    public partial class UserUnitForm : UserControl
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;

        public UserUnitForm()
        {
            InitializeComponent();

            RefreshDataSet();
        }

        private void unit_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    DataGridViewRow row = employee_gridData.Rows[e.RowIndex];

                    lbID.Text = row.Cells[0].Value.ToString();
                    fillTxt.Text = row.Cells[1].Value.ToString();
                    policeNum.Text = row.Cells[1].Value.ToString();
                    cbxStatus.SelectedValue = row.Cells[2].Value.ToString();
                    type.Text = row.Cells[3].Value.ToString();
                    merk.Text = row.Cells[4].Value.ToString();
                    capacity.Text = row.Cells[5].Value.ToString();
                }
            }
        }

        public DataSet Unit()
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM UnitTravel";
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "UnitTravel");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return dataSet;
        }

        public void RefreshDataSet()
        {
            employee_gridData.DataSource = Unit().Tables["UnitTravel"];
        }

        public DataSet SearchUnit(string keyword)
        {
            DataSet dataSet = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connect;
                cmd.CommandText = "SELECT * FROM UnitTravel WHERE nomor_polisi LIKE @keyword";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataSet, "UnitTravel");
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

            DataSet dataSet = SearchUnit(keyword);

            if (dataSet.Tables["UnitTravel"].Rows.Count == 0)
            {
                MessageBox.Show("\r\nNo suitable data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employee_gridData.DataSource = dataSet.Tables["UnitTravel"];
        }

        private void cancelBtnSearch_Click(object sender, EventArgs e)
        {
            policeNum.Text = string.Empty;
            type.Text = string.Empty;
            merk.Text = string.Empty;
            capacity.Text = string.Empty;
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

                SqlCommand delete = new SqlCommand("sp_DeleteUnit", connect);
                delete.CommandType = CommandType.StoredProcedure;

                parameter = delete.Parameters.Add("@id_unit", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = lbID.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = delete.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Unit deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        panelEditCreate.Visible = false;
                        fillTxt.Text = string.Empty;
                        create.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Unit deleted failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string newId = "UT001";
                int minId = 1;
                int maxId = int.MaxValue;

                SqlCommand getIdCmd = new SqlCommand("SELECT id_unit FROM UnitTravel", connect);
                try
                {
                    connect.Open();
                    SqlDataReader reader = getIdCmd.ExecuteReader();
                    List<int> existingIds = new List<int>();

                    while (reader.Read())
                    {
                        string currentId = reader["id_unit"].ToString();
                        int id = int.Parse(currentId.Substring(2));
                        existingIds.Add(id);
                    }

                    reader.Close();

                    for (int i = minId; i <= maxId; i++)
                    {
                        if (!existingIds.Contains(i))
                        {
                            newId = "UT" + i.ToString().PadLeft(3, '0');
                            break;
                        }
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
            if (policeNum.Text == "" || type.Text == "" || merk.Text == "" || capacity.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                string formattedPoliceNum = FormatPoliceNumber(policeNum.Text);

                SqlCommand insert = new SqlCommand("sp_InputUnit", connect);
                insert.CommandType = CommandType.StoredProcedure;

                insert.Parameters.AddWithValue("id_unit", lbID.Text);
                insert.Parameters.AddWithValue("no_polisi", formattedPoliceNum);
                insert.Parameters.AddWithValue("status_unit", cbxStatus.SelectedItem);
                insert.Parameters.AddWithValue("jenis_unit", type.Text);
                insert.Parameters.AddWithValue("merk_unit", merk.Text);
                insert.Parameters.AddWithValue("kapasitas", capacity.Text);

                try
                {
                    connect.Open();
                    insert.ExecuteNonQuery();

                    MessageBox.Show("Unit added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataSet();
                    panelEditCreate.Visible = false;
                    lbID.Text = string.Empty;
                    policeNum.Text = string.Empty;
                    cbxStatus.Text = string.Empty;
                    type.Text = string.Empty;
                    merk.Text = string.Empty;
                    capacity.Text = string.Empty;
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
            if (fillTxt.Text == "" || policeNum.Text == "" || merk.Text == "" || type.Text == "" || capacity.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlParameter parameter = new SqlParameter();

                string formattedPoliceNum = FormatPoliceNumber(policeNum.Text);

                SqlCommand update = new SqlCommand("sp_UpdateUnit", connect);
                update.CommandType = CommandType.StoredProcedure;

                parameter = update.Parameters.Add("@id_unit", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = lbID.Text;

                parameter = update.Parameters.Add("@no_polisi", SqlDbType.VarChar, 10);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = formattedPoliceNum;

                parameter = update.Parameters.Add("@status_unit", SqlDbType.VarChar, 15);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = cbxStatus.SelectedItem;

                parameter = update.Parameters.Add("@jenis_unit", SqlDbType.VarChar, 25);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = type.Text;

                parameter = update.Parameters.Add("@merk_unit", SqlDbType.VarChar, 20);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = merk.Text;

                parameter = update.Parameters.Add("@kapasitas", SqlDbType.Int);
                parameter.Direction = ParameterDirection.Input;
                parameter.Value = capacity.Text;

                try
                {
                    connect.Open();
                    int rowsAffected = update.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Unit updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataSet();
                        fillTxt.Text = string.Empty;
                        panelEditCreate.Visible = false;
                        policeNum.Text = string.Empty;
                        cbxStatus.Text = string.Empty;
                        type.Text = string.Empty;
                        merk.Text = string.Empty;
                        capacity.Text = string.Empty;
                        create.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Unit updated failed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string FormatPoliceNumber(string input)
        {
            string pattern = @"^([a-zA-Z]{1,2})(\d{1,4}\d)([a-zA-Z]{1,3})$";
            if (Regex.IsMatch(input, pattern))
            {
                return Regex.Replace(input, pattern, "${1} ${2} ${3}".ToUpper());
            }
            else
            {
                return input; 
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            policeNum.Text = string.Empty;
            cbxStatus.Text = string.Empty;
            type.Text = string.Empty;
            merk.Text = string.Empty;
            capacity.Text = string.Empty;
            panelEditCreate.Visible = false;
            create.Enabled = true;
            fillTxt.Text = string.Empty;
        }
    }
}
