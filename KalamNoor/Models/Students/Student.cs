namespace KalamNoor.Models.Students
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public bool IsMale { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public string WhatsAppPhoneNumber { get; set; }

        public string MobilePhoneNumber { get; set; }

        public string LandLine { get; set; }


        public DateTime JoinDate { get; set; }

        public DateTime LeaveDate { get; set; }

        public int FatherId { get; set; }
        public int MotherId { get; set; }
        public int AddressId { get; set; }
        public int ResponsiblePersonId { get; set; }
        public int PreviousSchoolId { get; set; }
    }
}
