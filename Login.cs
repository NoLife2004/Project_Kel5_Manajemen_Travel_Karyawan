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
    public partial class FromLogin : Form
    {
        public FromLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide(); // Menyembunyikan form saat ini
            AfterLogin afterLoginForm = new AfterLogin(); // Membuat instans dari form AfterLogin
            afterLoginForm.Show(); // Menampilkan form AfterLogin
        }
    }
}
