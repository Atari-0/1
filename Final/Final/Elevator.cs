using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double currentweight = 0; 
            foreach (Passenger Occupants in Occupants)
            {
                currentweight = Occupants.GetWeight();
            }
            return currentweight;
        }
        public bool IsOverMaxCapacity()
        {   if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
