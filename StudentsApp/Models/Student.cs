using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsApp.Models
{
    public class Student
    {
        public Student(int Id, string studentName, int age)
        {
            this.StudentId = Id;
            this.StudentName = studentName;
            this.Age = age;

        }
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int Age { get; set; }
    }
}