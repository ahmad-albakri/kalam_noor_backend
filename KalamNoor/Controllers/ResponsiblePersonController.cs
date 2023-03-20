using KalamNoor.Manager;
using KalamNoor.Models.Addresses;
using KalamNoor.Models.Families;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class ResponsiblePersonController : ControllerBase
    {
        [Route("ResponsiblePersonController/InsertResponsiblePerson")]
        [HttpPost]
        public int InsertResponsiblePerson([FromBody] ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonManager.InsertResponsiblePerson(responsiblePerson);
        }
        [Route("ResponsiblePersonController/UpdateResponsiblePerson")]
        [HttpPost]
        public int UpdateResponsiblePerson([FromBody] ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonManager.UpdateResponsiblePerson(responsiblePerson);
        }
        [Route("ResponsiblePersonController/DeleteResponsiblePerson")]
        [HttpPost]
        public int DeleteResponsiblePerson([FromBody] ResponsiblePerson responsiblePerson)
        {
            return ResponsiblePersonManager.DeleteResponsiblePerson(responsiblePerson);
        }
        [Route("ResponsiblePersonController/GetResponsiblePeoples")]
        [HttpGet]
        public List<ResponsiblePerson> GetResponsiblePeoples()
        {
            return ResponsiblePersonManager.GetResponsiblePeoples();
        }

    }
}
