namespace Lab4Movies
{
    public class Pricing
    {
        public const double mSenior = 4.5;
        public const double mAdult = 5.99;
        public const double mChild = 3.99;
        public const double eSenior = 8.5;
        public const double eAdult = 10.99;
        public const double eChild = 6.99;

        public const double csSoda = 3.5;
        public const double clSoda = 5.99;
        public const double chDog = 3.99;
        public const double cpCorn = 4.5;
        public const double ccandy = 1.99;

        public static bool AskforShowtime()
        {
            System.Console.Write("True or False.  Are you attending the matinee? ");
            return bool.Parse(System.Console.ReadLine());
        }

        public static int AskForPerson(string person)
        {
            System.Console.Write("How many " + person + " are attending? ");
            return int.Parse(System.Console.ReadLine());
        }

        public static int AskforInt(string item)
        {
             System.Console.Write("How many " + item + " would you like? ");
            return int.Parse(System.Console.ReadLine());
        }
    }
}