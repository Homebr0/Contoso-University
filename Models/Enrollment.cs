
namespace ContosoUniversity.Models
{
    using ContosoUniversity.Models;
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; } //Automatically the Course model's foreign key due to this naming convention
        public int StudentID { get; set; } //Same for Student
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
