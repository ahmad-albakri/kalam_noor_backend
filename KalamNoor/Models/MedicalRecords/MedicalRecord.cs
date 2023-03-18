namespace KalamNoor.Models.MedicalRecords
{
    public class MedicalRecord
    {
        public int ID { get; set; }

        public int StudentId { get; set; }
        public int VaccineId { get; set; }

        public string Note { get; set; }
    }
}
