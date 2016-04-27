using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication31.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Surname { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public Student()
        {
            Courses = new List<Course>();
        }
    }
}