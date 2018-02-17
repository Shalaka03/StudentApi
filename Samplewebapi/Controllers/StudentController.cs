
using student.webapi.core.IRepositories;
using student.webapi.core.Models;
using student.webapi.data.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Samplewebapi.Controllers
{
    public class StudentController : ApiController
    {
        private IStudentRepository _studentRepository; //= new StudentRepository();
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IEnumerable<Student> Get()
        {
            return _studentRepository.GetAllStudents();
        }

        // GET api/values/5
        public Student Get(int id)

        {
            return null;
           // return students.Where(student => student.Id == id).FirstOrDefault();
                
        }

        // POST api/values
        public void Post([FromBody]Student student)
        {
            //students.Add(student);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Student student)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
