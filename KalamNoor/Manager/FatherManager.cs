using KalamNoor.DataManager;
using KalamNoor.Models.Families;

namespace KalamNoor.Manager
{
    public abstract class FatherManager
    {
        public static List<Father> GetFathers()
        {
            return FatherDataManager.GetFathers().ToList();
        }
        public static int InsertFather(Father father)
        {
            return FatherDataManager.InsertFather(father);

        }
        public static int UpdateFather(Father father)
        {
            return FatherDataManager.UpdateFather(father);
        }
        public static int DeleteFather(Father father)
        {

            return FatherDataManager.DeleteFather(father);

        }
    }
}
