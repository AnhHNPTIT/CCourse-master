using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnManagerStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.ShowDialog();
        }

        private void btnManagerCourse_Click(object sender, EventArgs e)
        {
            FormCourse formCourse = new FormCourse();
            formCourse.ShowDialog();
        }

        private void btnManagerStudentStudy_Click(object sender, EventArgs e)
        {
            FormMarkOfStudent formMarkOfStudent = new FormMarkOfStudent();
            formMarkOfStudent.ShowDialog();
        }
    }
}
