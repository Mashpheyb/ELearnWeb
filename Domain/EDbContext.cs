using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELearnWeb.Domain
{
    public class EDbContext : DbContext
    {
        public EDbContext(DbContextOptions<EDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("user");

                e.HasKey(e => e.Id);

                e.Property(pr => pr.Id).HasColumnName("id");

                e.Property(pr => pr.FirstName).HasColumnName("fname");

                e.Property(pr => pr.LastName).HasColumnName("lname");

                e.Property(pr => pr.Email).HasColumnName("email");

                e.Property(pr => pr.IdentificationNo).HasColumnName("identificationno");

                e.Property(pr => pr.PasswordHash).HasColumnName("passwordhash");

                e.Property(pr => pr.PasswordSalt).HasColumnName("passwordsalt");

                e.Property(pr => pr.Role).HasColumnName("role");

            });

            modelBuilder.Entity<Course>(e =>
            {
                e.ToTable("courses");

                e.HasKey(e => e.Id);

                e.Property(pr => pr.Id).HasColumnName("id");

                e.Property(pr => pr.Name).HasColumnName("name");

                e.Property(pr => pr.Description).HasColumnName("description");

                e.Property(pr => pr.CreatedBy).HasColumnName("createdby");

                e.Property(pr => pr.AssignedTeacher).HasColumnName("assignedteacher");

            });

            modelBuilder.Entity<CourseStudents>(e =>
            {
                e.ToTable("coursestudents");

                e.HasKey(e => e.Id);

                e.Property(pr => pr.Id).HasColumnName("id");

                e.Property(pr => pr.StudentUserId).HasColumnName("studentuserid");

                e.Property(pr => pr.CourseId).HasColumnName("courseid");
            });

           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseStudents> CourseStudents { get; set; }

    }
}
