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
    public partial class CoursesSyllabus : Form
    {
        public CoursesSyllabus()
        {
            InitializeComponent();
        }


        private void CoursesSyllabus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataDataSet.TblCourses' table. You can move, or remove it, as needed.
            this.tblCoursesTableAdapter.Fill(this.myDataDataSet.TblCourses);

        }

    }
}
