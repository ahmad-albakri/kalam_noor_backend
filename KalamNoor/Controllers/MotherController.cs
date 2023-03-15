using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using KalamNoor.Models.Families;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class MotherController : ControllerBase
    {

        [Route("MotherController/InsertMother")]
        [HttpPost]

        public int InsertMother([FromBody] Mother mother)
        {
            return MotherManager.InsertMother(mother);
        }
        [Route("MotherController/UpdateMother")]
        [HttpPost]
        public int UpdateMother([FromBody] Mother mother)
        {
            return MotherManager.UpdateMother(mother);
        }
        [Route("MotherController/DeleteMother")]
        [HttpPost]
        public int DeleteMother([FromBody] Mother mother)
        {
            return MotherManager.DeleteMother(mother);
        }
        [Route("MotherController/GetMothers")]
        [HttpGet]
        public List<Mother> GetMothers()
        {
            return MotherManager.GetMothers();
        }

    }
}
