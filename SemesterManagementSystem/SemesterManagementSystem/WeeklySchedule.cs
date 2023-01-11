using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterManagementSystem
{
    public partial class WeeklySchedule : Form
    {
        public WeeklySchedule()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ScheduleUpdate myScheduleUpdate = new ScheduleUpdate();
            myScheduleUpdate.ShowDialog();
        }
    }
}
