namespace KalamNoor.Models.Exams
{
    public class Exam
    {
        public enum ExamTypeEnum
        {
            FirstExam = 0,
            SecondExam = 1,
            FinalExam = 2
            // ddddd
        }
        public int ID { get; set; }
        public ExamTypeEnum Type { get; set; }
        public int Precentage { get; set; }
        public int CourseId { get; set; }

    }
}
