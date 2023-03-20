using KalamNoor.DataManager;
using KalamNoor.Models.PsycologicalSataus;

namespace KalamNoor.Manager
{
    public abstract class PsychologicalStatusManager
    {
        public static List<PsychologicalStatus> GetPsychologicalStatuses()
        {
            return PsychologicalStatusDataManager.GetPsychologicalStatuss().ToList();
        }
        public static int InsertPsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusDataManager.InsertPsychologicalStatus(status);
        }
        public static int UpdatePsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusDataManager.UpdatePsychologicalStatus(status);
        }
        public static int DeletePsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusDataManager.DeletePsychologicalStatus(status);
        }

    }
}
