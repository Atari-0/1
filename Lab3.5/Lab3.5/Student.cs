using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade;

        public Student(string Name, Instructor Teacher, int Grade=0) { }

        public int RetrieveGrade() { return this.Grade; }

        public void SetGrade(int x) { this.Grade = x; }

        public void PrintInformation() { System.Console.WriteLine(Name, Teacher, Grade); }


    }
}
