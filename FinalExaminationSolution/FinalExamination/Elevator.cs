using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamination
{
    public class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }

       public void AddOccupants(Passenger passenger, int index)
       {
            Occupants[index].GetName();
            Occupants[index].GetWeight();
       }

        public double GetCurrentWeight(int index)
        {
           for (int i=0; i<index; i++)
          {
                double totalWeight = 0;
                totalWeight += Occupants[i].GetWeight();
                return totalWeight;  
           }
        }
        public bool IsOverMaxCapacity(double getCurrentWeight)
        {
            if (getCurrentWeight > MaxWeight)
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
