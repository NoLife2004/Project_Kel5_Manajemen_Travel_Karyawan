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
    public partial class UserScheduleForm : UserControl
    {
        public UserScheduleForm()
        {
            InitializeComponent();
            UserScheduleTripForm _scheduleTripForm = new UserScheduleTripForm();
            this.Controls.Add(_scheduleTripForm);
            _scheduleTripForm.Visible = false;
        }

        private void btnScheduleBus_Click(object sender, EventArgs e)
        {
            UserScheduleTripForm _scheduleTripForm = new UserScheduleTripForm();
            this.Visible = false;
            _scheduleTripForm.Visible = true;
        }

        private void btnScheduleTrip_Click(object sender, EventArgs e)
        {
            UserScheduleTripForm _scheduleTripForm = new UserScheduleTripForm();
            this.Visible = false;
            _scheduleTripForm.Visible = true;
            _scheduleTripForm.Show();

        }
    }
}
