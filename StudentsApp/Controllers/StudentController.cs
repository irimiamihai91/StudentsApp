using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsApp.Models;

namespace StudentsApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var students = GetList();

            return View(students);
        }

        public ActionResult Details(int id)
        {
            var students = GetList();
            var student = FindStudent(students, id);
            return View(student);
        }

        [HttpDelete]
        public ActionResult Detele( int id)
        {
            var students = GetList();
            DeleteById(students, id);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            //var students = GetList();
            //var student = students.Where(s => s.StudentId == id).FirstOrDefault();
            //return View(student);

            var students = GetList();
            var student = FindStudent(students, id);
            return View(student);
        }

        [NonAction]
        public List<Student> GetList()
        {
            Student s1 = new Student(1, "Popescu", 22);
            Student s2 = new Student(2, "Ionescu", 26);
            Student s3 = new Student(3, "Marcel", 23);
            Student s4 = new Student(4, "Vaile", 24);
            Student s5 = new Student(5, "Ion", 22);
            Student s6 = new Student(6, "Gheorghe", 26);
            Student s7 = new Student(7, "Daniel", 23);
            Student s8 = new Student(8, "Popoi", 24);

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);

            return students;
        }

        [NonAction]
        public Student FindStudent(List<Student> students, int id)
        {
            foreach(var stud in students)
            {
                if (stud.StudentId == id)
                {
                    return stud;
                }
            }
            return null;
        }

        [NonAction]
        public void DeleteById(List<Student> students, int id)
        {
            foreach(var stud in students)
            {
                if (stud.StudentId == id)
                {
                    students.Remove(stud);
                }

            }
        }
    }
}