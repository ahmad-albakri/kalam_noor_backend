using KalamNoor.DataManager;
using KalamNoor.Models.Classes;

namespace KalamNoor.Manager
{
    public abstract class CourseManager
    {
        public static int InsertCourse(Course course)
        {
            return CourseDataManager.InsertCourse(course);

        }
        public static int UpdateCourse(Course course)
        {
            return CourseDataManager.UpdateCourse(course);
        }
        public static int DeleteCourse(Course course)
        {
            return CourseDataManager.DeleteCourse(course);

        }
        public static List<Course> GetCourses()
        {
            return CourseDataManager.GetCourses().ToList();
        }
        public static Course GetCourseById(int id)
        {
            List<Course> courses = GetCourses();
            foreach (Course course in courses)
            {
                if (course.ID==id)
                {
                    return course;
                }
            }
            return null;
        }
    }
}
