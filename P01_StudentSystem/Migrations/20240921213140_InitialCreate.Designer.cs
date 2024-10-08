﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P01_StudentSystem.Data;

#nullable disable

namespace P01_StudentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240921213140_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P01_StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "تعلم أساسيات برمجة الويب",
                            EndDate = new DateTime(2024, 12, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(873),
                            Name = "برمجة ويب",
                            Price = 100.0,
                            StartDate = new DateTime(2024, 9, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(865)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "تعلم تصميم الجرافيك",
                            EndDate = new DateTime(2024, 11, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(888),
                            Name = "تصميم جرافيكي",
                            Price = 80.0,
                            StartDate = new DateTime(2024, 9, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(885)
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeworkId");

                    b.ToTable("Homeworks");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            Content = "مشروع برمجة",
                            ContentType = "Project",
                            CourseId = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2024, 9, 29, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(976)
                        },
                        new
                        {
                            HomeworkId = 2,
                            Content = "تصميم شعار",
                            ContentType = "Design",
                            CourseId = 2,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 9, 27, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(984)
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResourceId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            Name = "مقدمة في برمجة الويب",
                            ResourceType = "PDF",
                            Url = "http://example.com/resource1"
                        },
                        new
                        {
                            ResourceId = 2,
                            Name = "دورة تصميم الجرافيك",
                            ResourceType = "Video",
                            Url = "http://example.com/resource2"
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "أحمد",
                            RegisteredOn = new DateTime(2024, 9, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(532),
                            phoneNumber = "0123456789"
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = new DateTime(1999, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "فاطمة",
                            RegisteredOn = new DateTime(2024, 9, 22, 0, 31, 39, 225, DateTimeKind.Local).AddTicks(597),
                            phoneNumber = "9876543210"
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("P01_StudentSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("P01_StudentSystem.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P01_StudentSystem.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("P01_StudentSystem.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
