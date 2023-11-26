using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student { StudentID = 1, Name = "Frederick Candra", Email = "frederick@gmail.com", BirthDate = new DateOnly(2003, 1, 1)},
            new Student { StudentID = 2, Name = "Charles Candra", Email = "candra@gmail.com", BirthDate = new DateOnly(2004, 2, 2)},
            new Student { StudentID = 3, Name = "Jocelyn Candra", Email = "jocelyn@gmail.com", BirthDate = new DateOnly(2005, 3, 3)},
        };

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s => s.StudentID == id);
        }
    }
}