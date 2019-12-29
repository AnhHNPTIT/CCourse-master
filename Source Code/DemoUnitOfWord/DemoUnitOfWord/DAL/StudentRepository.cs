using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitOfWord.DAL
{
    class StudentRepository : IStudentRepository
    {
        private ProjectEntities context;
        public StudentRepository (ProjectEntities context)
        {
            this.context = context;
        }
        public void Delete(string studentId)
        {
            var studentToDelete = getStudentById(studentId);
            context.Students.Remove(studentToDelete);
        }

        public Student getStudentById(string id)
        {
            return context.Students.Find(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.ToList();
        }

        public void Insert(Student student)
        {
            context.Students.Add(student);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(Student student)
        {
            context.Entry(student).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
