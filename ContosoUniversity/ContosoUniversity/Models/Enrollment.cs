namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        //
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        /// <summary>
        /// 分数，后面的问号表示该字段可以为null
        /// </summary>
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}