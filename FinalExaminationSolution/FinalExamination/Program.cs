using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamination
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Elevator elevator1 = new Elevator(2, 400);

            Passenger pass11 = new Passenger("A1", 180);
            elevator1.AddOccupants(pass11, 0);
            Passenger pass12 = new Passenger("A2", 200);
            elevator1.AddOccupants(pass12, 1);

            double totalWeight1 = elevator1.GetCurrentWeight(1);
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity(totalWeight1);


            Elevator elevator2 = new Elevator(3, 600);
            Passenger pass21 = new Passenger("A1", 200);
            elevator2.AddOccupants(pass21, 0);
            Passenger pass22 = new Passenger("A2", 200);
            elevator2.AddOccupants(pass22, 1);
            Passenger pass23 = new Passenger("A3", 201);
            elevator2.AddOccupants(pass23, 2);

            double totalWeight2 = elevator2.GetCurrentWeight(2);
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity(totalWeight2);

        }
    }
}
