using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using KalamNoor.Models.Families;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class FatherController : ControllerBase
    {
        [Route("FatherController/InsertFather")]
        [HttpPost]
        public int InsertFather([FromBody] Father father)
        {
            return FatherManager.InsertFather(father);
        }
        [Route("FatherController/UpdateFather")]
        [HttpPost]
        public int UpdateFather([FromBody] Father father)
        {
            return FatherManager.UpdateFather(father);
        }
        [Route("FatherController/DeleteFather")]
        [HttpPost]
        public int DeleteFather([FromBody] Father father)
        {
            return FatherManager.DeleteFather(father);
        }
        [Route("FatherController/GetFathers")]
        [HttpGet]
        public List<Father> GetFathers()
        {
            return FatherManager.GetFathers();
        }

    }
}
