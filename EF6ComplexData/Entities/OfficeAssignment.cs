using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF6ComplexData.Entities
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }

        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
