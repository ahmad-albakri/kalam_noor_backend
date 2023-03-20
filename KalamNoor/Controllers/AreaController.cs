﻿using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class AreaController : ControllerBase
    {
        [Route("AreaController/InsertArea")]
        [HttpPost]
        public int InsertArea([FromBody] Area area)
        {
            return AreaManager.InsertArea(area);
        }
        [Route("AreaController/UpdateArea")]
        [HttpPost]
        public int UpdateArea([FromBody] Area area)
        {
            return AreaManager.UpdateArea(area);
        }
        [Route("AreaController/DeleteArea")]
        [HttpPost]
        public int DeleteArea([FromBody] Area area)
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
