using KalamNoor.DataManager;
using KalamNoor.Models.Students;

namespace KalamNoor.Manager
{
    public abstract class StudentManager
    {
        public static int InsertStudent(Student student)
        {
            return StudentDataManager.InsertStudent(student);
        }

        public static int UpdateStudent(Student student) {
            return StudentDataManager.UpdateStudent(student);
        }
        public static List<Student> GetStudents()
        {
            return StudentDataManager.GetStudents().ToList();


        }

    }
}
