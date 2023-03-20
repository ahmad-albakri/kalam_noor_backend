using KalamNoor.Manager;
using KalamNoor.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class ClassController : ControllerBase
    {
        [Route("ClassController/InsertClass")]
        [HttpPost]
        public int InsertClass([FromBody] Class cls)
        {
            return ClassManager.InsertClass(cls);
        }
        [Route("ClassController/UpdateClass")]
        [HttpPost]
        public int UpdateClass([FromBody] Class cls)
        {
            return ClassManager.UpdateClass(cls);
        }
        [Route("ClassController/DeleteClass")]
        [HttpPost]
        public int DeleteClass([FromBody] Class cls)
        {
            return ClassManager.DeleteClass(cls);
        }


        [Route("ClassController/GetClasses")]
        [HttpGet]
        public List<Class> GetClasses()
        {
            return ClassManager.GetClasses();
        }

    }

}

