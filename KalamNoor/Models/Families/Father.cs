namespace KalamNoor.Models.Families
{
    public class Father
    {
        public enum ReligionEnum
        {
            Islam = 0,
            Christianity = 1
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string LastName { get; set; }
        public string Carrer { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public ReligionEnum Religion { get; set; }
        public string TiePlace { get; set; }

        public string TieNumber { get; set; }
        public string NationalIdNumber { get; set; }


    }
}
