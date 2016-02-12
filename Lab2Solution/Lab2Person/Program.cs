namespace Lab2Person
{
    class Program
    {
        static void Main(string[] args)
        {
            bool maritalStatus;

            Person p1 = new Person();
            System.Console.Write("Person 1: ");
            p1.InputPersonData();  

            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            if (maritalStatus && true)
            {
                p1.SpouseInputData();
            }
            System.Console.WriteLine();


            //Person 2
            Person p2 = new Person();
            System.Console.Write("Person 2: ");
            //input person firstName, LastName, and age?
            p2.InputPersonData();
            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            if (maritalStatus && true)
            {
                p2.SpouseInputData();
            }
            System.Console.WriteLine();

            p1.PrintNameandAge();
            //p1spouse.PrintNameandAge();
            p2.PrintNameandAge();
            //p2spouse.PrintNameandAge();
            System.Console.WriteLine("The Average Age of these people is " + Person.SumOfAllAges / Person.count + " years old.");
            System.Console.WriteLine();
            
            
            System.Console.WriteLine();
            System.Console.WriteLine("Select any key to complete...");
            System.Console.ReadKey();
        }
    }
}
