using KalamNoor.Manager;
using KalamNoor.Models.Vaccines;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class VaccineController : ControllerBase
    {
        [Route("VaccineController/InsertVaccine")]
        [HttpPost]

        public int InsertVaccine([FromBody] Vaccine vaccine)
        {
            return VaccineManager.InsertVaccine(vaccine);
        }
        [Route("VaccineController/UpdateVaccine")]
        [HttpPost]

        public int UpdateVaccine([FromBody] Vaccine vaccine)
        {
            return VaccineManager.UpdateVaccine(vaccine);
        }
        [Route("VaccineController/DeleteVaccine")]
        [HttpPost]

        public int DeleteVaccine([FromBody] Vaccine vaccine)
        {
            return VaccineManager.DeleteVaccine(vaccine);
        }
        [Route("VaccineController/GetVaccines")]
        [HttpPost]
        public List<Vaccine> GetVaccines()
        {
            return VaccineManager.GetVaccines();
        }

    }
}
