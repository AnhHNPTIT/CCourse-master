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
    public partial class FormMarkOfStudent : Form
    {
        public FormMarkOfStudent()
        {
            InitializeComponent();
        }

        ProjectEntities db = new ProjectEntities();

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            ResetValue();
            txtStudentID.Enabled = true;
            txtStudentID.Focus();
        }

        private void ResetValue()
        {
            txtGradeNumber.Text = "";
            txtStudentID.Text = "";
        }

        private void FormMarkOfStudent_Load(object sender, EventArgs e)
        {
            txtStudentID.Enabled = false;
            btnSave.Enabled = false;
            //LoadData();
            var db = new ProjectEntities();

            // lay danh sach ten Lecturers
            var query = from Lec in db.Lecturers
                        select new { NameDistinct = Lec.Name };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstLecturer.Items.Add(item.NameDistinct);
            }

            // lay danh sach ten Courses
            query = from Cour in db.Courses
                    select new { NameDistinct = Cour.CourseName };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstCourse.Items.Add(item.NameDistinct);
            }

            // lay danh sach Year Study
            query = from YS in db.YearStudies
                    select new { NameDistinct = YS.Year.ToString() };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstYear.Items.Add(item.NameDistinct);
            }

            // lay danh sach ten ky hoc
            query = from YS in db.YearStudies
                    select new { NameDistinct = YS.Semester };
            query = query.Distinct();
            foreach (var item in query)
            {
                lstSemester.Items.Add(item.NameDistinct);
            }
        }

        private void LoadData()
        {
            var unitOfWork = new UnitOfWork();
            dataGridView1.DataSource = unitOfWork.StudentStudyRepository.Get();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            //lay ma sv can update
            string studentId = txtStudentID.Text;
            string yearStudyId = "", courseId = "", studentStudyId = "", lecturerId = "";

            // lay cac gia tri Ids tu cac listbox
            courseId = FindCourseId(lstCourse.SelectedItem.ToString());
            lecturerId = FindLectureId(lstLecturer.SelectedItem.ToString());
            yearStudyId = FindYearStudyId(Convert.ToInt32(lstYear.SelectedItem), lstSemester.SelectedItem.ToString());

            //tao khoa chinh
            studentStudyId = yearStudyId + courseId + studentId;
            int? gradeNumber = null;
            string gradeCharacter = TransferNumberToCharacter(gradeNumber);
            if (gradeNumber < 0 || gradeNumber > 100)
            {
                MessageBox.Show("You must enter 0 <= grade <= 100 !", "Thông báo");
                txtGradeNumber.Focus();
            }
            if (!CheckExistStudentID(txtStudentID.Text))
            {
                MessageBox.Show("You must enter existed student!", "Thông báo");
                txtStudentID.Focus();
            }
            else if (studentStudyId == "")
            {
                MessageBox.Show("You must enter infors!", "Thông báo");
                txtStudentID.Focus();
            }
            else if (CheckKey(studentStudyId))
            {
                MessageBox.Show("StudentStudyID is existed!", "Thông báo");
                txtStudentID.Focus();
            }
            else
            {
                unitOfWork.StudentStudyRepository.Insert(new StudentStudy
                {
                    StudentStudyID = studentStudyId,
                    StudentID = studentId,
                    LecturerID = lecturerId,
                    YearStudyID = yearStudyId,
                    CourseID = courseId,
                    GradeNumber = gradeNumber,
                    GradeCharacter = gradeCharacter

                });

                unitOfWork.SaveChanges();
                MessageBox.Show("New StudentStudy Inserted!");
                LoadData();
                ResetValue();
                btnInsert.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                txtStudentID.Enabled = false;
            }
        }

        private string FindCourseId(string text)
        {
            string courseId = "";
            var query = from Cour in db.Courses
                        where Cour.CourseName.Equals(text)
                        select Cour.CourseID;
            courseId = query.FirstOrDefault();
            return courseId;
        }

        private string FindLectureId(string text)
        {
            string lecturerId = "";
            var query = from Lec in db.Lecturers
                    where Lec.Name.Equals(text)
                    select Lec.LecturerID;
            lecturerId = query.FirstOrDefault();
            return lecturerId;
        }

        private string FindYearStudyId(int year, string semester)
        {
            string yearStudyId = "";
            var query = from Year in db.YearStudies
                    where Year.Semester.Equals(semester)
                    && Year.Year == year
                    select Year.YearStudyID;
            yearStudyId = query.FirstOrDefault();
            return yearStudyId;
        }

        private string TransferNumberToCharacter(int? gradeNumber)
        {
            string gradeCharacter = "";
            try
            {
                gradeNumber = Convert.ToInt32(txtGradeNumber.Text);
                if (0 < gradeNumber && gradeNumber < 40)
                {
                    gradeCharacter = "F";
                }
                else if (gradeNumber < 50)
                {
                    gradeCharacter = "D";
                }
                else if (gradeNumber < 70)
                {
                    gradeCharacter = "C";
                }
                else if (gradeNumber < 80)
                {
                    gradeCharacter = "B";
                }
                else
                {
                    gradeCharacter = "A";
                }
            }
            catch (Exception)
            {

            }
            
            return gradeCharacter;
        }

        private bool CheckKey(string text)
        {
            var db = new ProjectEntities();
            var query = from SS in db.StudentStudies
                        where SS.StudentStudyID.Equals(text)
                        select SS;
            return (query.Count() == 1);
        }

        private bool CheckExistStudentID(string id)
        {
            var db = new ProjectEntities();
            var query = from SS in db.Students
                        where SS.StudentID.Equals(id)
                        select SS;
            return (query.Count() == 1);
        }

        private string FindCourseName(string id)
        {
            string courseName = "";
            var query = from Cour in db.Courses
                        where Cour.CourseID.Equals(id)
                        select Cour.CourseName;
            courseName = query.FirstOrDefault();
            return courseName;
        }

        private string FindLecturerName(string id)
        {
            string lecturerName = "";
            var query = from Lec in db.Lecturers
                        where Lec.LecturerID.Equals(id)
                        select Lec.Name;
            lecturerName = query.FirstOrDefault();
            return lecturerName;
        }

        private string FindSemester(string id)
        {
            string semester = "";
            var query = from Year in db.YearStudies
                        where Year.YearStudyID.Equals(id)
                        select Year.Semester;
            semester = query.FirstOrDefault();
            return semester;
        }

        private int FindYear(string id)
        {
            int year;
            var query = from Year in db.YearStudies
                        where Year.YearStudyID.Equals(id)
                        select Year.Year;
            year = Convert.ToInt32(query.FirstOrDefault());
            return year;
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ResetValue();
            if (btnInsert.Enabled == false)
            {
                MessageBox.Show("Now in new addition mode!", "Thông báo");
                txtStudentID.Focus();
            }
            else if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data available", "Thông báo");
            }
            else
            {
                int currentRow = e.RowIndex;
                try
                {
                    txtStudentID.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
                    try
                    {
                        txtGradeNumber.Text = dataGridView1.Rows[currentRow].Cells[5].Value.ToString();

                    }
                    catch (Exception)
                    {

                    }
                    int indexCourse = lstCourse.FindString(FindCourseName(dataGridView1.Rows[currentRow].Cells[4].Value.ToString()));
                    lstCourse.SetSelected(indexCourse, true);
                    int indexLecturer = lstLecturer.FindString(FindLecturerName(dataGridView1.Rows[currentRow].Cells[2].Value.ToString()));
                    lstLecturer.SetSelected(indexLecturer, true);
                    int indexYear = lstYear.FindString(FindYear(dataGridView1.Rows[currentRow].Cells[3].Value.ToString()).ToString());
                    lstYear.SetSelected(indexYear, true);
                    int indexSemester = lstSemester.FindString(FindSemester(dataGridView1.Rows[currentRow].Cells[3].Value.ToString()));
                    lstSemester.SetSelected(indexSemester, true);  
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                //lay ma sv can update
                string studentId = txtStudentID.Text;
                string yearStudyId = "", courseId = "", studentStudyId = "", lecturerId = "";

                // lay cac gia tri Ids tu cac listbox
                courseId = FindCourseId(lstCourse.SelectedItem.ToString());
                lecturerId = FindLectureId(lstLecturer.SelectedItem.ToString());
                yearStudyId = FindYearStudyId(Convert.ToInt32(lstYear.SelectedItem), lstSemester.SelectedItem.ToString());

                //tao khoa chinh
                studentStudyId = yearStudyId + courseId + studentId;
                unitOfWork.StudentStudyRepository.Delete(studentStudyId);
                unitOfWork.SaveChanges();
                MessageBox.Show("A StudentStudy Deleted!");
                LoadData();
                ResetValue();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            //lay ma sv can update
            string studentId = txtStudentID.Text;
            string yearStudyId = "", courseId = "", studentStudyId = "", lecturerId = "";

            // lay cac gia tri Ids tu cac listbox
            courseId = FindCourseId(lstCourse.SelectedItem.ToString());
            lecturerId = FindLectureId(lstLecturer.SelectedItem.ToString());
            yearStudyId = FindYearStudyId(Convert.ToInt32(lstYear.SelectedItem), lstSemester.SelectedItem.ToString());

            //tao khoa chinh
            studentStudyId = yearStudyId + courseId + studentId;

            int? gradeNumber = Convert.ToInt32(txtGradeNumber.Text);
            string gradeCharacter = "";
            if (gradeNumber >= 0 && gradeNumber <= 100)
            {
                gradeCharacter = TransferNumberToCharacter(gradeNumber);
                unitOfWork.StudentStudyRepository.Update(new StudentStudy
                {
                    StudentStudyID = studentStudyId,
                    StudentID = studentId,
                    LecturerID = lecturerId,
                    YearStudyID = yearStudyId,
                    CourseID = courseId,
                    GradeNumber = gradeNumber,
                    GradeCharacter = gradeCharacter
                });
                unitOfWork.SaveChanges();
                MessageBox.Show("A StudentStudy Updated!");
                LoadData();
                ResetValue();
            }
            else
            {
                MessageBox.Show("You must enter 0 <= grade <= 100 !", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var year = Convert.ToInt32(lstYear.SelectedItem);
            var semester = lstSemester.SelectedItem.ToString();
            var lecturerName = lstLecturer.SelectedItem.ToString();
            var courseName = lstCourse.SelectedItem.ToString();
            var db = new ProjectEntities();
            var query = from SS in db.StudentStudies
                        join Lec in db.Lecturers
                        on SS.LecturerID equals Lec.LecturerID
                        join Cou in db.Courses
                        on SS.CourseID equals Cou.CourseID
                        join Year in db.YearStudies
                        on SS.YearStudyID equals Year.YearStudyID
                        where Lec.Name.Equals(lecturerName)
                        && Cou.CourseName.Equals(courseName)
                        && Year.Year == year
                        && Year.Semester.Equals(semester)
                        select SS;

            if (query.Count() >= 1)
            {
                foreach (var item in query)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    //int rowIndex = 1;
                    dataGridView1.Rows[rowIndex].Cells[0].Value = item.StudentStudyID;
                    dataGridView1.Rows[rowIndex].Cells[1].Value = item.StudentID;
                    dataGridView1.Rows[rowIndex].Cells[2].Value = item.LecturerID;
                    dataGridView1.Rows[rowIndex].Cells[3].Value = item.YearStudyID;
                    dataGridView1.Rows[rowIndex].Cells[4].Value = item.CourseID;
                    dataGridView1.Rows[rowIndex].Cells[5].Value = item.GradeNumber;
                    dataGridView1.Rows[rowIndex].Cells[6].Value = item.GradeCharacter;
                    rowIndex++;
                }


            }
            else
            {
                MessageBox.Show("No data avaliable", "Thông báo");
            }
        }
    }
    
}
