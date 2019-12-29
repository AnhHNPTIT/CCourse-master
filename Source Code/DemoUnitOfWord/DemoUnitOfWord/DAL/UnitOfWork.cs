using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUnitOfWord.DAL
{
    class UnitOfWork
    {
        private ProjectEntities context = new ProjectEntities();
        private StudentRepository studentRepository;
        public StudentRepository StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    studentRepository = new StudentRepository(context);
                }
                return studentRepository;
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
