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

namespace Project_Kel5_Manajemen_Travel
{
    public partial class UserEmployeeForm : UserControl
    {
        public UserEmployeeForm()
        {
            InitializeComponent();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            email.Text = string.Empty;
            phone.Text = string.Empty;
            username.Text = string.Empty;
            password.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
