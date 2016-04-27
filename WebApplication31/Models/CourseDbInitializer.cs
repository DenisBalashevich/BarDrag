﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication31.Models
{
    public class CourseDbInitializer : DropCreateDatabaseAlways<StudentsContext>
    {
        protected override void Seed(StudentsContext context)
        {
            Student s1 = new Student { Id = 1, Name = "Vodka", Surname = false, Photo = "vodka.jpg" };
            Student s2 = new Student { Id = 2, Name = "Whiskey", Surname = false, Photo = "whiskey.jpg" };
            Student s3 = new Student { Id = 3, Name = "Cola", Surname = false, Photo = "cola.jpg" };
            Student s4 = new Student { Id = 4, Name = "Juice", Surname = false, Photo = "juce.jpg" };

            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Students.Add(s3);
            context.Students.Add(s4);

            Course c1 = new Course
            {
                Id = 1,
                Name = "Whiskey & Cola",
                Photo = "wc.jpg",
                Students = new List<Student>() { s2, s3 }

            };
            Course c2 = new Course
            {
                Id = 2,
                Name = "Vodka & Cola",
                Photo = "vc.jpg",
                Students = new List<Student>() { s1, s3 }
            };
            Course c3 = new Course
            {
                Id = 3,
                Name = "Bloody mary",
                Photo = "merry.jpg",
                Students = new List<Student>() { s2, s4 }
            };

            context.Courses.Add(c1);
            context.Courses.Add(c2);
            context.Courses.Add(c3);

            base.Seed(context);
        }
    }
}