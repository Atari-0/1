using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._5
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public static double SumOfAllAges;
        double AverageOfAllAges;
        
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            System.Console.Write(GetFullName() + ",Age:" + Age);
        }


        public void UserInformation()
        {
            System.Console.Write("What is your first name? : ");
            FirstName = (System.Console.ReadLine());
            System.Console.Write("What is your last name? : ");
            LastName = (System.Console.ReadLine());
            System.Console.Write("Your full name is: " + GetFullName() + ". Please Press the Enter Key to Continue");
            System.Console.ReadLine();
            System.Console.Write("What is your Age?: ");
            Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += Age;
            this.Spouse = new Person();
            System.Console.Write("What is your spouse's first name? : ");
            Spouse.FirstName = (System.Console.ReadLine());
            Spouse.LastName = LastName;
            System.Console.Write("Your Spouse's full name is : " + Spouse.GetFullName() + ". Please Press the Enter Key to Continue");
            System.Console.ReadLine();
            System.Console.Write("How old is your spouse?: ");
            Spouse.Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += Spouse.Age;

            System.Console.Write("The sum of both couple's ages is : " + SumOfAllAges);
            AverageOfAllAges = SumOfAllAges / 4;
            System.Console.Write(". The average of all the ages is : " + AverageOfAllAges);
            System.Console.ReadLine(); 

            



        }

    }
}
