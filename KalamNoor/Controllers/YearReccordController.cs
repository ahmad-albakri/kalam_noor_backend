using KalamNoor.Manager;
using KalamNoor.Models.PreviousSchools;
using KalamNoor.Models.YearsRecords;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class YearReccordController : Controller
    {
        [Route("YearReccordController/InsertYearReccord")]
        [HttpPost]
        public int InsertYearReccord(YearRecord record)
        {
            return YearReccordManger.InsertYearReccord(record);
        }
        [Route("YearReccordController/UpdateYearREccord")]
        [HttpPost]
        public int UpdateYearReccord(YearRecord record)
        {
            return YearReccordManger.UpdateYearREccord(record);
        }
        [Route("YearReccordController/GetYearReccords")]
        [HttpGet]
        public List<YearRecord> GetYearReccords()
        {
            return YearReccordManger.GetYearRecords();
        }
    }
}
