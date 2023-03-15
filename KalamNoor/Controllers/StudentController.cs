using KalamNoor.Manager;
using KalamNoor.Models.Students;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class StudentController : ControllerBase
    {
        [Route("StudentController/InsertController")]
        [HttpPost]
        public int InsertStudent(Student student) { 
        return StudentManager.InsertStudent(student);
        }
        [Route("StudentController/UpdateStudent")]
        [HttpPost]
        public int UpdateStudent(Student student)
        {
            return StudentManager.UpdateStudent(student);
        }
        [Route("StudentController/GetStudents")]
        [HttpGet]
        public List<Student> GetStudents()
        {
            return StudentManager.GetStudents();
        }

    }
}
