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
        public FromLogin()
        {
            InitializeComponent();

            // Set the form to be full screen
            Screen screen = Screen.FromHandle(this.Handle);
            Rectangle bounds = screen.Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
            this.Size = new Size(bounds.Width, bounds.Height);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AfterLogin afterLoginForm = new AfterLogin();
            afterLoginForm.ShowDialog();
            this.Close();
        }
    }
}
