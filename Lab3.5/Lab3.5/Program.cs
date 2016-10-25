using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "English");
            Instructor mike = new Instructor("Mike", "Math");

            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.SetStudentGrade(jane, 94);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.Information();
            joe.Information();
            melissa.Information();
            matt.Information();

          
        }
    }
}
