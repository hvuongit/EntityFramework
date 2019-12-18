using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF6ComplexData.Entities

{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }

        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
