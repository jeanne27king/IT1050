namespace Lab4Movies
{
    public class Concession
    {
        public int sSoda;
        public int lSoda;
        public int hDog;
        public int pCorn;
        public int candy;
        public double consTotal;

        public Concession()
        {
            System.Console.WriteLine("Please Place Your Order...");
            System.Console.Write("How many small soda's would you like? ");
            this.sSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many large soda's would you like? ");
            this.lSoda = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many hot dogs would you like? ");
            this.hDog = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many popcorn would you like? ");
            this.pCorn = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many candy would you like? ");
            this.candy = int.Parse(System.Console.ReadLine());
        }

            //this.discVariable(Discounts, this.pCorn, this.lSoda, candy);

        public double calculateConcession()
        {
            consTotal = 0;
            consTotal += sSoda * 3.5;
            consTotal += lSoda * 5.99;
            consTotal += hDog * 3.99;
            consTotal += pCorn * 4.50;
            consTotal += candy * 1.99;
            System.Console.WriteLine("Your Concessions will cost " + consTotal);
            System.Console.WriteLine();

            return consTotal;
        }
    }
}