using KalamNoor.DataManager;
using KalamNoor.Models.PsychologicalStatus;

namespace KalamNoor.Manager
{
    public abstract class PsycologicalStatusesStudentManager
    {
        public static List<PsychologicalStatusesStudent> GetPsycologicalStatusesStudents()
        {
            return PsycologicalStatusesStudentDataManager.GetPsycologicalStatusesStudents().ToList();
        }
        public static int InsertPsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentDataManager.InsertPsycologicalStatusesStudent(statusesStudent);
        }
        public static int UpdatePsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentDataManager.UpdatePsycologicalStatusesStudent(statusesStudent);
        }
        public static int DeletePsycologicalStatusesStudent(PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentDataManager.DeletePsycologicalStatusesStudent(statusesStudent);
        }

    }
}
