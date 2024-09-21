﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }

         
    }
}
