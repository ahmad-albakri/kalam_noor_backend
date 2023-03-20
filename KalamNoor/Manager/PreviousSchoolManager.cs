using KalamNoor.DataManager;
using KalamNoor.Models.PreviousSchools;

namespace KalamNoor.Manager
{
    public abstract class PreviousSchoolManager
    {
        public static List<PreviousSchool> GetPreviousSchools()
        {
            return PreviousSchoolDataManager.GetPreviousSchools().ToList();
        }

        public static int InsertPreviousShcool(PreviousSchool previousSchool)
        {
            return PreviousSchoolDataManager.InsertPreviousSchool(previousSchool);
        }
        public static int UpdatePreviousShcool(PreviousSchool previousSchool)
        {
            return PreviousSchoolDataManager.UpdatePreviousSchool(previousSchool);
        }
        public static int DeletePreviousShcool(PreviousSchool previousSchool)
        {
            return PreviousSchoolDataManager.DeletePreviousSchool(previousSchool);
        }

    }
}
