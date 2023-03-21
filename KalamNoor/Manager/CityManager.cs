using KalamNoor.DataManager;
using KalamNoor.Models.Addresses;

namespace KalamNoor.Manager
{
    public abstract class CityManager
    {
        public static List<City> GetCities()
        {
            return CityDataManager.GetCities().ToList();
        }
        public static int InsertCity(City city)
        {
            return CityDataManager.InsertCity(city);
        }
      //TOODO:ADD CONTROLLER
        public static int UpdateCity(City city)
        {
            return CityDataManager.UpdateCity(city);
        }
        public static int DeleteCity(City city)
        {
            return CityDataManager.DeleteCity(city);
        }
        public static City GetCityById(int id)
        {
            List<City> cities = GetCities();
            foreach (City city in cities)
            {
                if (city.ID==id)
                {
                    return city;
                }
            }
                return null;
        }
    }
}
