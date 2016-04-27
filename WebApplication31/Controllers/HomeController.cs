using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    public class HomeController : Controller
    {
        private List<Student> StudentsContainer = new List<Student>();

        private StudentsContext db = new StudentsContext();

        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }
        public ActionResult CocktailsHDO(string name, string targetId)
        {
            var id = new List<Course>();
            int nm = Int32.Parse(name);
            if (targetId == "target")
                db.Students.Find(nm).Surname = true;
            else
                db.Students.Find(nm).Surname = false;
            db.SaveChanges();
            var curStudents = db.Students.Where(x => x.Surname);
            var curCourses = db.Courses.Where(x => x.Students.Intersect(curStudents).Count() == curStudents.Count() && curStudents.Count() !=0);
            return PartialView(curCourses.ToList());
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}