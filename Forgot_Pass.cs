using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Kel5_Manajemen_Travel
{
    public partial class Forgot_Pass : Form
    {
        public Forgot_Pass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromLogin login = new FromLogin();
            login.ShowDialog();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromLogin login = new FromLogin();
            login.ShowDialog();
        }
    }
}
