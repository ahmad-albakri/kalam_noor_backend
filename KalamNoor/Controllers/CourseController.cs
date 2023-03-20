using KalamNoor.Manager;
using KalamNoor.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class CourseController : ControllerBase
    {
        [Route("CourseController/InsertCourse")]
        [HttpPost]
        public int InsertCourse([FromBody] Course course)
        {
            return CourseManager.InsertCourse(course);
        }
        [Route("CourseController/UpdateCourse")]
        [HttpPost]
        public int UpdateCourse([FromBody] Course course)
        {
            return CourseManager.UpdateCourse(course);
        }
        [Route("CourseController/DeleteCourse")]
        [HttpPost]
        public int DeleteCourse([FromBody] Course course)
        {
            return CourseManager.DeleteCourse(course);
        }
        [Route("CourseController/GetCourses")]
        [HttpGet]
        public List<Course> GetCourses()
        {
            return CourseManager.GetCourses();
        }

    }
}
