using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class CityController : ControllerBase
    {
        [Route("CityController/InsertCity")]
        [HttpPost]
        public int InsertCity([FromBody] City city)
        {
            return CityManager.InsertCity(city);
        }

        [Route("CityController/GetCities")]
        [HttpGet]
        public List<City> GetCities() { 
        return CityManager.GetCities();
        
        }

    }
}
