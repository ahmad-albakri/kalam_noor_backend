using KalamNoor.Manager;
using KalamNoor.Models.MedicalRecords;
using KalamNoor.Models.Students;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class StudentController : ControllerBase
    {
        [Route("StudentController/InsertStudent")]
        [HttpPost]
        public int InsertStudent(Student student)
        {
            return StudentManager.InsertStudent(student);
        }
        [Route("StudentController/UpdateStudent")]
        [HttpPost]
        public int UpdateStudent(Student student)
        {
            return StudentManager.UpdateStudent(student);
        }
        [Route("StudentController/GetStudents")]
        [HttpGet]
        public List<Student> GetStudents()
        {
            return StudentManager.GetStudents();
        }

        #region MedicalRecord Controller
        [Route("StudentController/InsertMedicalRecord")]
        [HttpPost]
        public int InsertMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordManager.InsertMedicalRecord(medicalRecord);
        }
        [Route("StudentController/UpdateMedicalRecord")]
        [HttpPost]
        public int UpdateMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordManager.UpdateMedicalRecord(medicalRecord);
        }
        [Route("StudentController/DeleteMedicalRecord")]
        [HttpPost]
        public int DeleteMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordManager.DeleteMedicalRecord(medicalRecord);
        }
        [Route("StudentController/GetMedicalRecords")]
        [HttpGet]
        public List<MedicalRecord> GetMedicalRecords()
        {
            return MedicalRecordManager.GetMedicalRecords();
        }

        #endregion

    }
}
