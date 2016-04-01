
namespace Lab4Movies
{
    public class CstmrTicket
    {
        public bool showTime;

        public int qsSoda;
        public int qlSoda;
        public int qhDog;
        public int qpCorn;
        public int qcandy;
        public double qconsTotal;

        public int cChild;
        public int cAdult;
        public int cSenior;
        public int totalPeople;
        public double ticketCost;
        public double consTotal;
        public double discount;

        public CstmrTicket()
        {
            //True is matinee, false is evening 
            this.showTime = Pricing.AskforShowtime();

            //Number of seniors attending
            this.cSenior = Pricing.AskForPerson("seniors");

            //Number of adults attending
            this.cAdult = Pricing.AskForPerson("adults");

            //Number of children attending
            this.cChild = Pricing.AskForPerson("children");
            System.Console.WriteLine();

            //Count number of people to be used for the discount
            this.totalPeople = this.cSenior + this.cAdult + this.cChild;
        }

        public void GetConcessionOrder()
        {
            System.Console.WriteLine("Please Place Your Concession Order...");
            this.qsSoda = Pricing.AskforInt("small soda's");
            this.qlSoda = Pricing.AskforInt("large soda 's");
            this.qhDog = Pricing.AskforInt("hot dog's");
            this.qpCorn = Pricing.AskforInt("popcorn");
            this.qcandy = Pricing.AskforInt("candy");
        }

        //total concession cost
        public double calculateConcession()
        {
            consTotal = 0;
            consTotal += Pricing.csSoda * qsSoda;
            consTotal += Pricing.clSoda * qlSoda;
            consTotal += Pricing.chDog * qhDog;
            consTotal += Pricing.cpCorn * qpCorn;
            consTotal += Pricing.ccandy * qcandy;
            System.Console.WriteLine();
            System.Console.WriteLine("Your Concession total is $" + consTotal);
            return consTotal;
        }

        //total discount
        public double calculateDiscount()
        {
            discount = 0;
            if (this.qpCorn > 0 & this.qlSoda > 0 & this.totalPeople>0)
            {
                discount += 2;
             }

            if (this.showTime=false & this.totalPeople > 2)
            {
                 System.Console.WriteLine("Please have a free popcorn!");
            }

            if (qcandy > 3)
            {
                int x = qcandy / 3;
                System.Console.WriteLine("Please may have " + x + " free candy!");
            }
            System.Console.WriteLine("Your discount is $" + discount);
            return discount;
        }

         //total ticket cost
        public double calculateTicket()
        {
            if (this.showTime == true)
            {
                ticketCost = 0;
                ticketCost += this.cSenior * Pricing.mSenior;
                ticketCost += this.cAdult * Pricing.mAdult;
                ticketCost += this.cChild * Pricing.mChild;
                System.Console.WriteLine("Your Tickets will Cost $" + ticketCost);
                System.Console.WriteLine();
                return ticketCost;
            }
            else
            {
                ticketCost = 0;
                ticketCost += cSenior * Pricing.eSenior;
                ticketCost += cAdult * Pricing.eAdult;
                ticketCost += cChild * Pricing.eChild;
                System.Console.WriteLine("Your Tickets will Cost $" + ticketCost);
                System.Console.WriteLine();

                return ticketCost;
            }

        }
    }
}
