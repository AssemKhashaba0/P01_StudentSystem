using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial catalog=P01_StudentSystem; Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });

            modelBuilder.Entity<StudentCourse>()
           .HasOne(e => e.Student)
           .WithMany(e => e.StudentCourses)
           .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(e => e.Course)
                .WithMany(e => e.StudentCourses)
                .HasForeignKey(e => e.CourseId);


            //الجزء ده معمول ب ChatGpt

            // إضافة بيانات الطلاب
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "أحمد", phoneNumber = "0123456789", RegisteredOn = DateTime.Now, Birthday = new DateTime(2000, 1, 1) },
                new Student { StudentId = 2, Name = "فاطمة", phoneNumber = "9876543210", RegisteredOn = DateTime.Now, Birthday = new DateTime(1999, 5, 15) }
            );

            // إضافة بيانات الدورات
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 1, Name = "برمجة ويب", Description = "تعلم أساسيات برمجة الويب", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(3), Price = 100 },
                new Course { CourseId = 2, Name = "تصميم جرافيكي", Description = "تعلم تصميم الجرافيك", StartDate = DateTime.Now, EndDate = DateTime.Now.AddMonths(2), Price = 80 }
            );

            // إضافة بيانات الموارد
            modelBuilder.Entity<Resource>().HasData(
                new Resource { ResourceId = 1, Name = "مقدمة في برمجة الويب", Url = "http://example.com/resource1", ResourceType = "PDF" },
                new Resource { ResourceId = 2, Name = "دورة تصميم الجرافيك", Url = "http://example.com/resource2", ResourceType = "Video" }
            );

            // إضافة بيانات الواجبات
            modelBuilder.Entity<Homework>().HasData(
                new Homework { HomeworkId = 1, Content = "مشروع برمجة", ContentType = "Project", SubmissionTime = DateTime.Now.AddDays(7), StudentId = 1, CourseId = 1 },
                new Homework { HomeworkId = 2, Content = "تصميم شعار", ContentType = "Design", SubmissionTime = DateTime.Now.AddDays(5), StudentId = 2, CourseId = 2 }
            );

            // إضافة بيانات الربط بين الطلاب والدورات
            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 1 },
                new StudentCourse { StudentId = 2, CourseId = 2 }
            );


        }




}
}
