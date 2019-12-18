using System;
using System.Collections.Generic;


namespace EF6ComplexData.Entities
{
    public class Instructor
    {
        public int InstructorId { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Department> Departments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<Course> Courses { get; set; }
        public override string ToString()
        {
            return "Name: " + this.LastName + " " + FirstMidName + "\nHire day: " + this.HireDate;
        }
    }
}
