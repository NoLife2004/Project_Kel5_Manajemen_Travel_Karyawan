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
        }

        private void btnScheduleBus_Click(object sender, EventArgs e)
        {

        }

        private void btnScheduleTrip_Click(object sender, EventArgs e)
        {
            UserScheduleTripForm scheduleTrip = new UserScheduleTripForm();
            UserScheduleForm schedule = new UserScheduleForm();
            scheduleTrip.Visible = true;
            schedule.Visible = false;

        }
    }
}
