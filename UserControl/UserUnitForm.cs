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
    public partial class UserUnitForm : UserControl
    {
        SqlConnection connect = new SqlConnection("integrated security=true; data source=.; initial catalog=NexTrip_Adventure");
        private DataSet NexTrip_Adventure;
        public UserUnitForm()
        {
            InitializeComponent();
            RefreshDataSet();
        }

        private void employee_gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
