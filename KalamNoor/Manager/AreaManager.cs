using KalamNoor.DataManager;
using KalamNoor.Models.Addresses;

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
        public static Area GetAreaById(int id)
        {
            List<Area> areas = GetAreas();
            foreach (Area area in areas)
            {
                if (area.ID==id)
                {
                    return area;
                }
            }
            return null;
        }
        //TOODO: ADD CONTROLLER
    }
}
