using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitOfWord.DAL
{
    interface IStudentRepository
    {
        IEnumerable<Student> GetStudents();
        Student getStudentById(string id);
        void Delete(string studentId);
        void Update(Student student);
        void Insert(Student student);
        void Save();
    }
}
