using KalamNoor.Manager;
using KalamNoor.Models.Areas;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class AreaController : ControllerBase
    {
        [Route("AreaController/InsertArea")]
        [HttpPost]
        public int InsertArea(Area area)
        {
            return AreaManager.InsertArea(area);
        }
        [Route("AreaController/UpdateArea")]
        [HttpPost]
        public int UpdateArea(Area area)
        {
            return AreaManager.UpdateArea(area);
        }
        [Route("AreaController/DeleteArea")]
        [HttpPost]
        public int DeleteArea(Area area)
        {
            return AreaManager.DeleteArea(area);
        }
        [Route("AreaController/GetAreas")]
        [HttpGet]
        public List<Area> GetAreas()
        {
            return AreaManager.GetAreas();
        }



    }
}
