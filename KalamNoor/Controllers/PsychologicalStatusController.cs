﻿using KalamNoor.Manager;
using KalamNoor.Models.PsycologicalSataus;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class PsychologicalStatusController : ControllerBase
    {
        [Route("PsychologicalStatusController/InsertPsychologicalStatus")]
        [HttpPost]
        public int InsertPsychologicalStatus([FromBody] PsychologicalStatus status)
        {
            return PsychologicalStatusManager.InsertPsychologicalStatus(status);
        }
        [Route("PsychologicalStatusController/UpdatePsychologicalStatus")]
        [HttpPost]
        public int UpdatePsychologicalStatus([FromBody] PsychologicalStatus status)
        {
            return PsychologicalStatusManager.UpdatePsychologicalStatus(status);
        }
        [Route("PsychologicalStatusController/DeletePsychologicalStatus")]
        [HttpPost]
        public int DeletePsychologicalStatus([FromBody] PsychologicalStatus status)

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
