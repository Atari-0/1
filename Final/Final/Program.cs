using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A1, 0);
            elevator1.AddOccupant(A2, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();

            Elevator elevator2 = new Elevator(3, 600);
            Passenger elevator2A1 = new Passenger("A1", 200);
            Passenger elevator2A2 = new Passenger("A2", 200);
            Passenger elevator2A3 = new Passenger("A3", 201);
            elevator2.AddOccupant(elevator2A1, 0);
            elevator2.AddOccupant(elevator2A2, 1);
            elevator2.AddOccupant(elevator2A3, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

            

        }
    }
}
