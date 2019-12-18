using EF6ComplexData.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6ComplexData.Classes
{
    public class Instructor
    {
        public int InstructorID { get; set; }
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
