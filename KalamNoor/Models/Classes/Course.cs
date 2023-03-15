namespace KalamNoor.Models.Classes
{
    public class Course
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int TotalMark { get; set; }

        public int ClassId { get; set; }
        public bool IsEnrichment { get; set; }
    }
}
