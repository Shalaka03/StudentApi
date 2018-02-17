using System;
using student.webapi.core.IRepositories;
using System.Collections.Generic;
using student.webapi.core.Models;

namespace student.webapi.data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> students = new List<Student>();
        public StudentRepository()
        {
            students.Add(new Student { Id = 1, Name = "RAM", Address = "Thane" });
            students.Add(new Student { Id = 2, Name = "Sita", Address = "Thane1" });
            students.Add(new Student { Id = 2, Name = "Sita1", Address = "Thane2" });

        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
