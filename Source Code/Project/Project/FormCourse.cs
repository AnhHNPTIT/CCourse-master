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
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace Project
{
    public partial class FormCourse : Form
    {
        public FormCourse()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnInsert.Enabled = false;
            ResetValue();
            txtCourseID.Enabled = true;
            txtCourseID.Focus();
        }

        private void ResetValue()
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtCredit.Text = "";
            txtFirstDateCreated.Text = "";
        }

        private void FormCourse_Load(object sender, EventArgs e)
        {
            txtCourseID.Enabled = false;
            btnSave.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            var unitOfWork = new UnitOfWork();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)));
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.DataSource = unitOfWork.CourseRepository.Get();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.CourseRepository.Update(new Course
            {
                CourseID = txtCourseID.Text,
                CourseName = txtCourseName.Text,
                Credit = txtCredit.Text,
                FirstDateCreated = txtFirstDateCreated.Text
            });
            unitOfWork.SaveChanges();
            MessageBox.Show("A course Updated!");
            LoadData();
            ResetValue();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.CourseRepository.Delete(txtCourseID.Text);
                unitOfWork.SaveChanges();
                MessageBox.Show("A course Deleted!");
                LoadData();
                ResetValue();
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ResetValue();
            if (btnInsert.Enabled == false)
            {
                MessageBox.Show("Now in new addition mode!", "Thông báo");
                txtCourseID.Focus();
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
                    txtCourseID.Text = dataGridView1.Rows[currentRow].Cells[0].Value.ToString();
                    txtCourseName.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
                    txtCredit.Text = dataGridView1.Rows[currentRow].Cells[2].Value.ToString();
                    txtFirstDateCreated.Text = dataGridView1.Rows[currentRow].Cells[3].Value.ToString();
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook ExcelWorkBook = null;
            Worksheet ExcelWorkSheet = null;
            ExcelApp.Visible = true;
            ExcelWorkBook = ExcelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);

            try
            {
                ExcelWorkSheet = ExcelWorkBook.Worksheets[1]; // Compulsory Line in which sheet you want to write data
                // Storing header part in Excel
                for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                {
                    ExcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // Storing each row and column value to excel sheet                
                for (int r = 0; r < dataGridView1.Columns.Count - 1; r++)
                {
                    for (int c = 0; c < dataGridView1.Columns.Count; c++)
                        try
                        {
                            ExcelWorkSheet.Cells[r + 2, c + 1] = dataGridView1.Rows[r].Cells[c].Value.ToString();
                        }
                        catch (Exception)
                        {

                        }
                }
                ExcelWorkBook.Worksheets[1].Name = "MySheet";//Renaming the Sheet1 to MySheet
                ExcelWorkBook.Worksheets[1].UsedRange.AutofitColumns();
                ExcelWorkBook.SaveAs("E:\\Courses.xlsx");
                ExcelWorkBook.Close();
                ExcelApp.Quit();
                Marshal.ReleaseComObject(ExcelWorkSheet);
                Marshal.ReleaseComObject(ExcelWorkBook);
                Marshal.ReleaseComObject(ExcelApp);
            }
            catch (Exception exHandle)
            {
                MessageBox.Show(exHandle.Message);
            }
            finally
            {
                foreach (Process process in Process.GetProcessesByName("Excel"))
                {
                    process.Kill();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (txtCourseID.Text.Length == 0)
            {
                MessageBox.Show("Field CourseId couldn't not null!", "Thông báo");
                txtCourseID.Focus();
            }
            else if (CheckKey(txtCourseID.Text))
            {
                MessageBox.Show("CourseId is existed!", "Thông báo");
                txtCourseID.Focus();
            }
            else
            {
                unitOfWork.CourseRepository.Insert(new Course
                {
                    CourseID = txtCourseID.Text,
                    CourseName = txtCourseName.Text,
                    Credit = txtCredit.Text,
                    FirstDateCreated = txtFirstDateCreated.Text
                });

                unitOfWork.SaveChanges();
                MessageBox.Show("New course Inserted!");
                LoadData();
                ResetValue();
                btnInsert.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                txtCourseID.Enabled = false;
            }
        }

        private bool CheckKey(string text)
        {
            var db = new ProjectEntities();           
            var query = from C in db.Courses
                        where C.CourseID.Equals(text)
                        select C;
            return (query.Count() == 1);
        }
    }
}
