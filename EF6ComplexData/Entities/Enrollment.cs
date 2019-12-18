using System.ComponentModel.DataAnnotations.Schema;

namespace EF6ComplexData.Entities
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Grade { get; set; }
    }
}
