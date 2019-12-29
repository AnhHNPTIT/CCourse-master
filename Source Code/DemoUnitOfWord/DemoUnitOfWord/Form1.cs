using DemoUnitOfWord.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUnitOfWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.StudentRepository.Insert(new Student
            {
                StudentID = textBoxId.Text,
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text
            });
            // Save tất cả thay đổi trong database không chỉ của Student
            unitOfWork.SaveChanges();
            MessageBox.Show("New student Inserted!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            dataGridView1.DataSource = unitOfWork.StudentRepository.GetStudents();
        }
    }
}
