using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.UserInformation();


            System.Console.WriteLine("Summary of User's answers");
            p1.PrintNameAndAge();
            System.Console.ReadLine();
            System.Console.WriteLine("Summary of Spouse's Answers");
            p1.Spouse.PrintNameAndAge();
            System.Console.ReadLine();

            System.Console.Write("Now pass the console to the next user. Please Press Enter to continue afterwards.");
            System.Console.ReadLine();
            Person p2 = new Person();

            p2.UserInformation();
            System.Console.WriteLine("Summary of User's answers");
            p2.PrintNameAndAge();
            System.Console.ReadLine();
            System.Console.WriteLine("Summary of Spouse's answers");
            p2.Spouse.PrintNameAndAge();
            System.Console.ReadLine(); 

            System.Threading.Thread.Sleep(3000);
        }
    }
}
