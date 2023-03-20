using KalamNoor.Manager;
using KalamNoor.Models.PsycologicalSataus;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class PsychologicalStatusController : ControllerBase
    {
        [Route("PsychologicalStatusController/InsertPsychologicalStatus")]
        [HttpPost]
        public int InsertPsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusManager.InsertPsychologicalStatus(status);
        }
        [Route("PsychologicalStatusController/UpdatePsychologicalStatus")]
        [HttpPost]
        public int UpdatePsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusManager.UpdatePsychologicalStatus(status);
        }
        [Route("PsychologicalStatusController/DeletePsychologicalStatus")]
        [HttpPost]
        public int DeletePsychologicalStatus(PsychologicalStatus status)
        {
            return PsychologicalStatusManager.DeletePsychologicalStatus(status);
        }
        [Route("PsychologicalStatusController/GetPsychologicalStatusess")]
        [HttpGet]
        public List<PsychologicalStatus> GetPsychologicalStatuses( )

        {
            return PsychologicalStatusManager.GetPsychologicalStatuses();
        }

    }
}
