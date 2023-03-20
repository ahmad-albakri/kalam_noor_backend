using KalamNoor.Manager;
using KalamNoor.Models.PreviousSchools;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class PreviousSchoolController : ControllerBase
    {
        [Route("PreviousSchoolController/InserPreviousSchool")]
        [HttpPost]
        public int InsertPreviousSchool(PreviousSchool previousSchool)
        {
            return PreviousSchoolManager.InsertPreviousShcool(previousSchool);
        }

        [Route("PreviousSchoolController/UpdatePreviousShcool")]
        [HttpPost]
        public int UpdatePreviousShcool(PreviousSchool previousSchool)
        {
            return PreviousSchoolManager.UpdatePreviousShcool(previousSchool);
        }

        [Route("PreviousSchoolController/DeletePreviousShcool")]
        [HttpPost]
        public int DeletePreviousShcool(PreviousSchool previousSchool)
        {
            return PreviousSchoolManager.DeletePreviousShcool(previousSchool);
        }
        [Route("PreviousSchoolController/DeletePreviousShcool")]
        [HttpGet]
        public List<PreviousSchool> GetPreviousSchools()
        {
            return PreviousSchoolManager.GetPreviousSchools();
        }
    }
}
