using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetx;
            int targety;
            int destinationx;
            int destinationy;
        
            string[,] board = new string[8, 8] //shout out to mad max for his much more clear and readable board. Couldn't figure out how to make one this clear.
            {

                {"X","X","X","X","X","X","X","X"},
                {"X","X","X","X","X","X","X","X"},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {" "," "," "," "," "," "," "," "},
                {"X","X","X","X","X","X","X","X"},
                {"X","X","X","X","X","X","X","X"},

            };

            showBoard(board);
            System.Console.WriteLine("What X coordinate would you like to move?");
            targetx = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("What Y coordinate would you like to move?");
            targety = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Where would you like to move that X coordinate to ?");
            destinationx = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Where would you like to move that Y coordinate to?");
            destinationy = int.Parse(System.Console.ReadLine());


            if (targetx<8&&targety<8&&destinationx<8&&destinationy<8)
            {
                board[targetx, targety] = board[destinationx, destinationy];
                board[targetx, targety] = " ";
                showBoard(board);
                Console.Clear();
            }
            else
            {
                System.Console.WriteLine("ERROR, AN INPUTED VALUE WAS OUT OF RANGE. NOW SHUTTING DOWN.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
            while (1)
            {
                showBoard(board);
                System.Console.WriteLine("What X coordinate would you like to move?");
                targetx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("What Y coordinate would you like to move?");
                targety = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Where would you like to move that X coordinate to ?");
                destinationx = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("Where would you like to move that Y coordinate to?");
                destinationy = int.Parse(System.Console.ReadLine());
                if (targetx<8&&targety<8&&destinationx < 8 && destinationy < 8)
                {
                    board[targetx, targety] = board[destinationx, destinationy];
                    board[targetx, targety] = " ";
                    showBoard(board);
                    Console.Clear();
                }
            }


        }
        public static void showBoard(string[,] board)
        {
            string horizontal = ("+---+---+---+---+---+---+---+---+");


            for (int i = 0; i < 8; i++)
            {
                System.Console.WriteLine(horizontal);

                for (int j = 0; j < 8; j++)
                {
                    System.Console.Write("| " + board[i, j] + " ");

                }
                System.Console.WriteLine("|");

            }
            System.Console.WriteLine("+---+---+---+---+---+---+---+---+");

        }
    }
}

