using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("First Name : ");
            string firstName = System.Console.ReadLine();

            System.Console.Write("Middle Initial : ");
            string middleInitial = System.Console.ReadLine();

            System.Console.Write("Last Name : ");
            string lastName = System.Console.ReadLine();

            string fullName = firstName + " " + middleInitial + " " + lastName;
            System.Console.WriteLine(" Your full name is : " + fullName);

            System.Console.Write("Height in feet : ");
            int heightInFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Extra inches : ");
            double extraInches = double.Parse(System.Console.ReadLine());

            double heightInInches = heightInFeet * 12;
            double totalInches = heightInInches + extraInches;
            double heightInCM = totalInches * 2.54;
            System.Console.WriteLine("Your height in cm is : " + heightInCM);

            System.Console.Write("What age are you? ");
            int userAge = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Are you a citizen of the United States?");
            bool isCitizen = System.Console.ReadLine().StartsWith("y");

            System.Console.Write("Are you Eligible to Vote? : ");
            bool canVote = userAge >= 18 && isCitizen;
            System.Console.WriteLine("Eligibility to vote: " + canVote);

            System.Threading.Thread.Sleep(3000);
        }
    }
}
