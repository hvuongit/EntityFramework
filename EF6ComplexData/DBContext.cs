using EF6ComplexData.Classes;
using EF6ComplexData.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EF6ComplexData
{
    class DBContext : DbContext
    {
        public DBContext() : base("name=SchoolDBConnectionString")
        {
            //Database.SetInitializer<DBContext>(new DropCreateDatabaseAlways<DBContext>());
            Database.SetInitializer<DBContext>(null);
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Types()
               .Configure(c => c.ToTable(c.ClrType.Name));

            modelBuilder.Entity<Instructor>()
               .HasMany<Course>(s => s.Courses)
               .WithMany(c => c.Instructors)
               .Map(cs =>
               {
                   cs.MapLeftKey("InstructorID");
                   cs.MapRightKey("CourseID");
                   cs.ToTable("Teaching");
               });

        }
    }
}
