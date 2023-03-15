using KalamNoor.Manager;
using KalamNoor.Models.Areas;
using KalamNoor.Models.Classes;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class ClassController : ControllerBase
    {
        [Route("ClassController/InsertClass")]
        [HttpPost]
        public int InsertClass(Class cls)
        {
            return ClassManager.InsertClass(cls);
        }
        [Route("ClassController/UpdateClass")]
        [HttpPost]
        public int UpdateClass(Class cls)
        {
            return ClassManager.UpdateClass(cls);
        }
        [Route("ClassController/DeleteClass")]
        [HttpPost]
        public int DeleteClass(Class cls)
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

