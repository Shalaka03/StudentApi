using student.webapi.core.Models;
using System.Collections.Generic;

namespace student.webapi.core.IRepositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();
    }
}
