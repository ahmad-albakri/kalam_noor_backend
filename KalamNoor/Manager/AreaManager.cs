using KalamNoor.DataManager;
using KalamNoor.Models.Areas;

namespace KalamNoor.Manager
{
    public abstract class AreaManager
    {
        public static int InsertArea(Area area)
        {
            return AreaDataManager.InsertArea(area);
        }
        public static int DeleteArea(Area area)
        {
            return AreaDataManager.DeleteArea(area);
        }
        public static List<Area> GetAreas()
        {
            return AreaDataManager.GetAreas().ToList();
        }
        public static int UpdateArea(Area area)
        {
            return AreaDataManager.UpdateArea(area);

        }
    }
}
