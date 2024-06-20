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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                this.Hide();
                FromLogin login = new FromLogin();
                login.ShowDialog();
            }
        }

        private void tripBundleBtn_Click(object sender, EventArgs e)
        {
            userTripBundleForm.Visible = true;
            userPromosForm.Visible = false;
            userUnitForm.Visible = false;
            userEmployeeForm.Visible = false;
            userRoleForm.Visible = false;
        }

        private void promoBtn_Click(object sender, EventArgs e)
        {
            userTripBundleForm.Visible = false;
            userPromosForm.Visible = true;
            userUnitForm.Visible = false;
            userEmployeeForm.Visible = false;
            userRoleForm.Visible = false;
        }

        private void unitBtn_Click(object sender, EventArgs e)
        {
            userTripBundleForm.Visible = false;
            userPromosForm.Visible = false;
            userUnitForm.Visible = true;
            userEmployeeForm.Visible = false;
            userRoleForm.Visible = false;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            userTripBundleForm.Visible = false;
            userPromosForm.Visible = false;
            userUnitForm.Visible = false;
            userEmployeeForm.Visible = true;
            userRoleForm.Visible = false;
        }

        private void roleBtn_Click(object sender, EventArgs e)
        {
            userTripBundleForm.Visible = false;
            userPromosForm.Visible = false;
            userUnitForm.Visible = false;
            userEmployeeForm.Visible = false;
            userRoleForm.Visible = true;
        }     
    }
}
