using System.Data.Entity.ModelConfiguration.Conventions;
using Repository.Model.SchoolContext;

namespace Repository.Logic.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolContext : DbContext
    {
        // Your context has been configured to use a 'SchoolContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Repository.Logic.Repositories.SchoolContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SchoolContext' 
        // connection string in the application configuration file.

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Course>()
                .HasMany(c => c.Instructors).WithMany(i => i.Courses)
                .Map(t => t.MapLeftKey("CourseID")
                    .MapRightKey("PersonID")
                    .ToTable("CourseInstructor"));
        }
    }


}