using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Cinema Price Planner! Matinee hours or evening hours?");
            string input = System.Console.ReadLine();
            bool ismatinee = input.Contains("Matinee");
            System.Console.WriteLine("Enter only numerical values for the following questions. How many adults are you purchasing tickets for?");
            int AdultTickets = int.Parse(System.Console.ReadLine());
            double PriceofAdultTickets = ismatinee ? 5.99 : 10.99;
            System.Console.WriteLine("How many children are you purchasing tickets for?");
            int ChildTickets = int.Parse(System.Console.ReadLine());
            double PriceofChildrenTickets = ismatinee ? 3.99 : 6.99;
            System.Console.WriteLine("Lastly, how many seniors are you purchasing tickets for?");
            int SeniorTickets = int.Parse(System.Console.ReadLine());
            double PriceofSeniorTickets = ismatinee ? 4.50 : 8.50;
            double TotalNumberofAllTickets = AdultTickets + ChildTickets + SeniorTickets;
            double TotalPriceofTickets = PriceofAdultTickets*AdultTickets + PriceofChildrenTickets*ChildTickets + PriceofSeniorTickets*SeniorTickets;
            System.Console.WriteLine(TotalPriceofTickets);
            System.Console.WriteLine("Ok. Now lets move onto the concession stand.");
            System.Console.WriteLine("How many bags of popcorn do you plan to purchase?");
            int BagsofPopcorn = int.Parse(System.Console.ReadLine());
            bool isDiscountonPopcorn = TotalNumberofAllTickets > 3;
            double PriceofBagsofPopcorn = isDiscountonPopcorn ? BagsofPopcorn * 4.50 + TotalNumberofAllTickets/3*-4.50 : BagsofPopcorn * 4.50;
            System.Console.WriteLine("How many Large Sodas will you buy? Every pair purchase of a bag of popcorn and a large soda reduces the price of by $2");
            int LargeSodas = int.Parse(System.Console.ReadLine());
            double PriceofLargeSodas = LargeSodas * 5.99;
            if (TotalNumberofAllTickets>3 && BagsofPopcorn>1 && LargeSodas>1)
            {
                double MinimumofConsessions = Math.Min(BagsofPopcorn, LargeSodas);
                double MovieTicketDiscount = MinimumofConsessions * 2;
                System.Console.WriteLine("How many Small Sodas will you be purchasing?");
                int SmallSodas = int.Parse(System.Console.ReadLine());
                double PriceofSmallSodas = SmallSodas * 3.50;
                System.Console.WriteLine("How many candies do you plan on purchasing? Please note that purchasing 3 candies earns you a 4th for free.");
                int Candies = int.Parse(System.Console.ReadLine());
                bool isDiscountOnCandies = Candies >= 3;
                double PriceofCandies = isDiscountOnCandies ? Candies * 1.99 + Candies / 3 * -1.99 : Candies * 1.99;
                System.Console.WriteLine("How many Hot Dogs do you plan on Purchasing?");
                int Hotdogs = int.Parse(System.Console.ReadLine());
                double PriceofHotDogs = Hotdogs * 3.99;
                double TotalPriceofConcessions = PriceofBagsofPopcorn + PriceofLargeSodas + PriceofSmallSodas + PriceofCandies + PriceofHotDogs + MovieTicketDiscount;

                double FinalPrice = TotalPriceofTickets + TotalPriceofConcessions;
                System.Console.WriteLine("Ok! The grand total of your Cinema Trip is" + FinalPrice + "dollars.");
            }
            else
            {
                System.Console.WriteLine("How many Small Sodas will you be purchasing?");
                int SmallSodas = int.Parse(System.Console.ReadLine());
                double PriceofSmallSodas = SmallSodas * 3.50;
                System.Console.WriteLine("How many candies do you plan on purchasing? Please note that purchasing 3 candies earns you a 4th for free.");
                int Candies = int.Parse(System.Console.ReadLine());
                bool isDiscountOnCandies = Candies >= 3;
                double PriceofCandies = isDiscountOnCandies ? Candies * 1.99 + Candies / 3 * -1.99 : Candies * 1.99;
                System.Console.WriteLine("How many Hot Dogs do you plan on Purchasing?");
                int Hotdogs = int.Parse(System.Console.ReadLine());
                double PriceofHotDogs = Hotdogs * 3.99;
                double TotalPriceofConcessions = PriceofBagsofPopcorn + PriceofLargeSodas + PriceofSmallSodas + PriceofCandies + PriceofHotDogs;

                double FinalPrice = TotalPriceofTickets + TotalPriceofConcessions;
                System.Console.WriteLine("Ok! The grand total of your Cinema Trip is" + FinalPrice + "dollars.");
                System.Threading.Thread.Sleep(3000);

            }












        }
    }
}
