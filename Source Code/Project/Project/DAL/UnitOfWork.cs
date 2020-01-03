using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL
{
    public class UnitOfWork 
    {
        private ProjectEntities context = new ProjectEntities();

        private GenericRepository<Course> courseRepository;
        public GenericRepository<Course> CourseRepository
        {
            get
            {
                if (courseRepository == null)
                {
                    this.courseRepository = new GenericRepository<Course>(context);
                }
                return courseRepository;
            }
        }

        private GenericRepository<Student> studentRepository;
        public GenericRepository<Student> StudentRepository
        {
            get
            {
                if (studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(context);
                }
                return studentRepository;
            }
        }

        private GenericRepository<StudentStudy> studentStudyRepository;
        public GenericRepository<StudentStudy> StudentStudyRepository
        {
            get
            {
                if (studentStudyRepository == null)
                {
                    this.studentStudyRepository = new GenericRepository<StudentStudy>(context);
                }
                return studentStudyRepository;
            }
        }

        private GenericRepository<YearStudy> yearStudyRepository;
        public GenericRepository<YearStudy> YearStudyRepository
        {
            get
            {
                if (yearStudyRepository == null)
                {
                    this.yearStudyRepository = new GenericRepository<YearStudy>(context);
                }
                return yearStudyRepository;
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}

