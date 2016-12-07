using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string FirstName, string CourseName) 
        {
            this.Name = FirstName;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student Student, int Grade) { Student.SetGrade(Grade); }

        public void PrintFullName() { System.Console.WriteLine(Name, CourseName); }
    }
}
