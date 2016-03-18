
namespace Lab4Movies
{
    public class CstmrTicket
    {
        public bool showTime;

        public int cChild;
        public int cAdult;
        public int cSenior;
        public int totalPeople;
        public double ticketCost;
        public double consTotal;
        //public Discounts;

        public CstmrTicket()
        {
            //True is matinee, false is evening 
            System.Console.WriteLine("Welcome to our Theater...");
            System.Console.Write("True or False.  Are you attending the matinee? ");
            this.showTime = bool.Parse(System.Console.ReadLine());

            //Number of seniors attending
            System.Console.Write("How many seniors are attending? ");
            this.cSenior = int.Parse(System.Console.ReadLine());

            //Number of adults attending
            System.Console.Write("How many adults are attending? ");
            this.cAdult = int.Parse(System.Console.ReadLine());

            //Number of children attending
            System.Console.Write("How many children are attending? ");
            this.cChild = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();

            //Count number of people to be used for the discount
            totalPeople = this.cSenior + this.cAdult + this.cChild;
        }

            //ticket cost
        public double calculateTicket()
        { if (this.showTime == true)
            {
                ticketCost = 0;
                ticketCost += this.cSenior * 4.5;
                ticketCost += this.cAdult * 5.99;
                ticketCost += this.cChild * 3.99;
                System.Console.WriteLine("Your Tickets will Cost " + ticketCost);
                System.Console.WriteLine();

                return ticketCost;
            }
            else
            {
                ticketCost = 0;
                ticketCost += cSenior * 8.5;
                ticketCost += cAdult * 10.99;
                ticketCost += cChild * 6.99;
                System.Console.WriteLine("Your Tickets will Cost " + ticketCost);
                System.Console.WriteLine();

                return ticketCost;
            }

        }
    }
}
