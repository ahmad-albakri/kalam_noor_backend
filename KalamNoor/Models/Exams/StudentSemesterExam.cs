namespace KalamNoor.Models.Exams
{
    public class StudentSemesterExam
    {
        public int StudentSemesterExamId { get; set; }
        public int ExamId { get; set; }
        public int StudentSemesterId { get; set; }
        public double ObtainedMark { get; set; }
    }
}
