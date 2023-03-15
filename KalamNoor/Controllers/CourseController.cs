using KalamNoor.Manager;
using KalamNoor.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class CourseController : ControllerBase
    {
        [Route("CourseController/InsertCourse")]
        [HttpPost]
        public int InsertCourse(Course course)
        {
            return CourseManager.InsertCourse(course);
        }
        [Route("CourseController/UpdateCourse")]
        [HttpPost]
        public int UpdateCourse(Course course)
        {
            return CourseManager.UpdateCourse(course);
        }
        [Route("CourseController/DeleteCourse")]
        [HttpPost]
        public int DeleteCourse(Course course)
        {
            return CourseManager.DeleteCourse(course);
        }
        [Route("CourseController/GetCourses")]
        [HttpPost]
        public List<Course> GetCourses()
        {
            return CourseManager.GetCourses();
        }

    }
}
