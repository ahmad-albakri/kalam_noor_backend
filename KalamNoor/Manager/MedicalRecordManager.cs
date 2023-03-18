using KalamNoor.DataManager;
using KalamNoor.Models.MedicalRecords;

namespace KalamNoor.Manager
{
    public abstract class MedicalRecordManager
    {
        public static List<MedicalRecord> GetMedicalRecords()
        {
            return MedicalRecordDataManager.GetMedicalRecords().ToList();
        }
        public static int InsertMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordDataManager.InsertMedicalRecord(medicalRecord);

        }
        public static int UpdateMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordDataManager.UpdateMedicalRecord(medicalRecord);

        }
        public static int DeleteMedicalRecord(MedicalRecord medicalRecord)
        {
            return MedicalRecordDataManager.DeleteMedicalRecord(medicalRecord);

        }


    }
}
