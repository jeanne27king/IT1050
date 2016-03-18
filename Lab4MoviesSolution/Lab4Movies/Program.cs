namespace Lab4Movies
{
    class Program
    {
        static void Main(string[] args)
        {   
            double totalCost=0;

            //Create Customer Ticket, Concessions and Discount
            CstmrTicket c1 = new CstmrTicket();
            Concession cc1 = new Concession();
            //Discounts cd1 = new Discounts();

            //Create Customer Ticket Sales
            c1.calculateTicket(); 
        
            //Create Customer Concession Order
            cc1.calculateConcession();

            //Calculate Discount;
            //cd1.calculateDiscount();

            //Calculate Total Cost
            totalCost = c1.ticketCost + cc1.consTotal;
            System.Console.WriteLine("Your Total Bill Today is " + totalCost);
            System.Console.Write("Press any key to complete your order!");
            System.Console.ReadKey();
        }
    }
}