using EF6ComplexData.Classes;
using EF6ComplexData.Entities;
using HibernatingRhinos.Profiler.Appender.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF6ComplexData
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityFrameworkProfiler.Initialize();

            using (DBContext ctx = new DBContext())
            {
                //--- add data
                /* Student s = new Student() { LastName = Faker.NameFaker.LastName(), FirstMidName = Faker.NameFaker.FirstName(), HireDate = Faker.DateTimeFaker.DateTime() };
                ctx.students.add(s);
                instructor i = new instructor() { lastname = faker.namefaker.lastname(), firstmidname = faker.namefaker.firstname(), hiredate = faker.datetimefaker.datetime() };
                ctx.instructors.add(i);
                officeassignment o = new officeassignment() { instructorid = i.instructorid, location = faker.locationfaker.city() };
                ctx.officeassignments.add(o);
                department d = new department() { name = faker.companyfaker.name(), budget = faker.numberfaker.number() + 000, startdate = faker.datetimefaker.datetime(), instructorid = i.instructorid };
                ctx.departments.add(d);
                course c = new course() { title = faker.companyfaker.name(), credits = faker.numberfaker.number(), departmentid = d.departmentid };
                ctx.courses.add(c);
                enrollment e = new enrollment() { grade = faker.numberfaker.number(), studentid = s.id, courseid = c.courseid };
                ctx.enrollments.add(e); */

                //query:
                var result = ctx.Departments.Include(d => d.Courses).ToList();
                foreach(var item in result)
                {
                    foreach(var c in item.Courses)
                    {
                        Console.WriteLine("Department Name: " + item.Name + "\tBudget: " + item.Budget + "\tCourse Name: " + c.Title);
                    }
                }


                ctx.SaveChanges();
            }
        }
    }
}
