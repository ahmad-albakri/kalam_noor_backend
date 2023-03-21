using KalamNoor.Manager;
using KalamNoor.Models.MedicalRecords;
using KalamNoor.Models.PsychologicalStatus;
using KalamNoor.Models.Students;
using Microsoft.AspNetCore.Mvc;

namespace KalamNoor.Controllers
{
    public class StudentController : ControllerBase
    {
        #region StudentController

        [Route("StudentController/InsertStudent")]
        [HttpPost]
        public int InsertStudent([FromBody] Student student)
        {
            return StudentManager.InsertStudent(student);
        }
        [Route("StudentController/UpdateStudent")]
        [HttpPost]
        public int UpdateStudent([FromBody] Student student)
        {
            return StudentManager.UpdateStudent(student);
        }
        [Route("StudentController/GetStudents")]
        [HttpGet]
        public List<Student> GetStudents()
        {
            return StudentManager.GetStudents();
        }
        [Route("StudentController/GetStudentById")]
        [HttpGet]
        public Student GetStudentById(int id)
        {
            return StudentManager.GetStudentById(id);
        }
        [Route("StudentController/GetStudentByName")]
        [HttpGet]
        public List<Student> GetStudentByName(string name)
        {
            return StudentManager.GetStudentByName(name);
        }
        [Route("StudentController/GetStudentsByIsMale")]
        [HttpGet]
        public List<Student> GetMaleStudents( )
        {
            return StudentManager.GetStudentsByIsMale();
        }
        [Route("StudentController/GetStudentsByIsFemale")]
        [HttpGet]
        public List<Student> GetFemaleStudents()
        {
            return StudentManager.GetStudentsByIsFemale();
        }
        [Route("StudentController/GetStudentsByFatherId")]
        [HttpGet]
        public List<Student> GetStudentByFatherId(int id) {
            return StudentManager.GetStudentsByFatherId(id);
        }
        [Route("StudentController/GetStudentsByMotherId")]
        [HttpGet]
        public List<Student> GetStudentsByMotherId(int id)
        {
            return StudentManager.GetStudentsByMotherId(id);
        }


        #endregion

        #region MedicalRecord Controller

        [Route("StudentController/InsertMedicalRecord")]
        [HttpPost]
        public int InsertMedicalRecord([FromBody] MedicalRecord medicalRecord)
        {
            return MedicalRecordManager.InsertMedicalRecord(medicalRecord);
        }
        [Route("StudentController/UpdateMedicalRecord")]
        [HttpPost]
        public int UpdateMedicalRecord([FromBody] MedicalRecord medicalRecord)
        {
            return MedicalRecordManager.UpdateMedicalRecord(medicalRecord);
        }
        [Route("StudentController/DeleteMedicalRecord")]
        [HttpPost]
        public int DeleteMedicalRecord([FromBody] MedicalRecord medicalRecord)
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

        #region PsycologicalStatusesStudent Controller
        [Route("StudentController/InsertPsychologicalStatusesStudent")]
        [HttpPost]
        public int InsertPsycologicalStatusesStudent([FromBody] PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentManager.InsertPsycologicalStatusesStudent(statusesStudent);
        }
        [Route("StudentController/UpdatePsychologicalStatusesStudent")]
        [HttpPost]
        public int UpdatePsycologicalStatusesStudent([FromBody] PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentManager.UpdatePsycologicalStatusesStudent(statusesStudent);
        }
        [Route("StudentController/DeletePsychologicalStatusesStudent")]
        [HttpPost]
        public int DeletePsycologicalStatusesStudent([FromBody] PsychologicalStatusesStudent statusesStudent)
        {
            return PsycologicalStatusesStudentManager.DeletePsycologicalStatusesStudent(statusesStudent);
        }
        [Route("StudentController/DeletePsychologicalStatusesStudent")]
        [HttpGet]
        public List<PsychologicalStatusesStudent> GetPsycologicalStatusesStudents()
        {
            return PsycologicalStatusesStudentManager.GetPsycologicalStatusesStudents();
        }

        #endregion
    }
}
