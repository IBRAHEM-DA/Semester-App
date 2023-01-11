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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnWeeklySch_Click(object sender, EventArgs e)
        {
            WeeklySchedule myWeeklySchedule = new WeeklySchedule();
            myWeeklySchedule.ShowDialog();
        }

        private void btnCoursesSyllabus_Click(object sender, EventArgs e)
        {
            CoursesSyllabus myCoursesSyllabus = new CoursesSyllabus();
            myCoursesSyllabus.ShowDialog();
        }

        private void btnLecturerInfo_Click(object sender, EventArgs e)
        {
            LecturerInfo myLecturerInfo = new LecturerInfo();
            myLecturerInfo.ShowDialog();
        }

        private void btnAdmiInfo_Click(object sender, EventArgs e)
        {
            AdministrationInfo myAdministrationInfo = new AdministrationInfo();
            myAdministrationInfo.ShowDialog();
        }

        private void btnGradeCalc_Click(object sender, EventArgs e)
        {
            GradeCalculator myGradeCalculator = new GradeCalculator();
            myGradeCalculator.ShowDialog();
        }
    }
}
