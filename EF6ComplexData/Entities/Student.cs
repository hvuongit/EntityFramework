using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6ComplexData.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

        public override string ToString()
        {
            return "Name: " + this.LastName + " " + FirstMidName + "\nHire day: " + this.HireDate;
        }
    }
}
