using System.Xml.Linq;
using KalamNoor.DataManager;
using KalamNoor.Models.Families;
using KalamNoor.Models.Students;

namespace KalamNoor.Manager
{
    public abstract class StudentManager
    {
        public static int InsertStudent(Student student)
        {
            return StudentDataManager.InsertStudent(student);
        }
        public static int UpdateStudent(Student student)
        {
            return StudentDataManager.UpdateStudent(student);
        }
        public static List<Student> GetStudents()
        {
            return StudentDataManager.GetStudents().ToList();


        }
        public static Student GetStudentById(int id)
        {
            List<Student> students = GetStudents();
            foreach (Student student in students)
            {
                if (student.ID == id)
                {
                    return student;
                }
            }
            return null;
        }
        public static List<Student> GetStudentByName(string name)
        {
            List<Student> students = GetStudents();
            List<Student> result = new List<Student>();
            foreach (Student item in students)
            {
                if (item.FirstName.ToLower().Trim().Contains(name.ToLower().Trim()))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<Student> GetStudentsByIsMale()
        {
            List<Student> students = GetStudents();
            List<Student> result = new List<Student>();
            foreach (Student item in students)
            {
                if (item.IsMale == true)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<Student> GetStudentsByIsFemale()
        {
            List<Student> students = GetStudents();
            List<Student> result = new List<Student>();
            foreach (Student item in students)
            {
                if (item.IsMale == false)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<Student> GetStudentsByFatherId(int fatherId)
        {
            List<Student> students = GetStudents();
            List<Student> result = new List<Student>();
            foreach (Student item in students)
            {
                if (item.FatherId== fatherId)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<Student> GetStudentsByMotherId(int motherId)
        {
            List<Student> students = GetStudents();
            List<Student> result = new List<Student>();
            foreach (Student item in students)
            {
                if (item.MotherId == motherId)
                {
                    result.Add(item);
                }
            }
            return result;

        }


    }
}
