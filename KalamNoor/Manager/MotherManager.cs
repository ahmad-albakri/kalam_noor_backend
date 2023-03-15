using KalamNoor.DataManager;
using KalamNoor.Models.Families;

namespace KalamNoor.Manager
{
    public abstract class MotherManager
    {
        public static List<Mother> GetMothers()
        {
            return MotherDataManager.GetMothers().ToList();
        }
        public static int InsertMother(Mother mother) { 
        return MotherDataManager.InsertMother(mother);
        }
        public static int UpdateMother(Mother mother)
        {
            return MotherDataManager.UpdateMother(mother);
        }
        public static int DeleteMother(Mother mother)
        {
            return MotherDataManager.DeleteMother(mother);
        }
    }
}
