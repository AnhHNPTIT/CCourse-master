using Project.DAL;
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
    public partial class FormStudentStudy : Form
    {
        public FormStudentStudy()
        {
            InitializeComponent();
        }

        private void FormStudentStudy_Load(object sender, EventArgs e)
        {
            txtStudentID.Enabled = false;
            txtStudentName.Enabled = false;
            var db = new ProjectEntities();
            var query = from Lec in db.Lecturers
                        select new { NameDistinct = Lec.Name };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstLecturer.Items.Add(item.NameDistinct);
            }

            query = from Cour in db.Courses
                    select new { NameDistinct = Cour.CourseName };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstCourse.Items.Add(item.NameDistinct);
            }

            //query = from YS in db.YearStudies
            //        select new { NameDistinct = Convert.ToString(YS.Year) };
            //query = query.Distinct();
            //foreach (var item in query)
            //{
            //    lstYear.Items.Add(item.NameDistinct);
            //}

            query = from YS in db.YearStudies
                    select new { NameDistinct = YS.Semester };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstSemester.Items.Add(item.NameDistinct);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();

        }

        private void LoadData()
        {
            var db = new ProjectEntities();
            var query = from SS in db.StudentStudies
                        join Lec in db.Lecturers
                        on SS.LecturerID equals Lec.LecturerID
                        join Stu in db.Students
                        on SS.StudentID equals Stu.StudentID
                        join Cou in db.Courses
                        on SS.CourseID equals Cou.CourseID
                        where Lec.Name.Equals(lstLecturer.SelectedItem.ToString())
                        && Cou.CourseName.Equals(lstCourse.SelectedItem.ToString())
                        select new { SS.StudentStudyID, SS.StudentID, Stu.FirstName, Stu.LastName, SS.GradeNumber, SS.GradeCharacter };

            if (query.Count() >= 1)
            {
                foreach (var item in query)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[rowIndex].Cells[0].Value = item.StudentStudyID;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = item.StudentID;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = item.FirstName;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = item.LastName;
                    dataGridView1.Rows[rowIndex].Cells[4].Value = item.GradeNumber;
                    dataGridView1.Rows[rowIndex].Cells[5].Value = item.GradeCharacter;
                    rowIndex++;
                }
            }
            else
            {
                MessageBox.Show("No data avaliable", "Thông báo");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available", "Thông báo");
            }
            else
            {

                try
                {
                    txtStudentID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtStudentName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString()
                        + " " + dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtGradeNumber.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //lay ma sv can update
            string studentId = txtStudentID.Text;
            string yearStudyId="", courseId="", studentStudyId="" ;
            // lay cac gia tri Ids tu cac textbox

            //tao khoa chinh
            studentStudyId =  yearStudyId + courseId + studentId;




            UnitOfWork unitOfWork = new UnitOfWork();
          
            unitOfWork.StudentStudyRepository.Update(new StudentStudy
            {
                GradeNumber = Convert.ToInt32(txtGradeNumber.Text)
            });
            unitOfWork.SaveChanges();
            MessageBox.Show("A course Updated!");
            LoadData();
            txtGradeNumber.Text = "";
        }
    }
}
