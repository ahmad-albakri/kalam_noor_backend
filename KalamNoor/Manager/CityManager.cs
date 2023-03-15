using KalamNoor.DataManager;
using KalamNoor.Models.Cities;

namespace KalamNoor.Manager
{
    public abstract class CityManager
    {
        public static List<City> GetCities()
        {

            return CityDataManager.GetCities().ToList();

        }
        public static int InsertCity(City city) { 
        return CityDataManager.InsertCity(city);
        
        }
    }
}
