namespace Lab2Person
{
    class Program
    {
        static void Main(string[] args)
        {
            bool maritalStatus;

            //Person 1
            Person p1 = new Person();
            System.Console.WriteLine("Person 1: ");

            p1.InputPersonData();           //input person firstName, LastName, and age?  

            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            if (maritalStatus)      //if married then invoke methode and create new person spouse
                {
                p1.SpouseInputData();
                }
            System.Console.WriteLine();

            //Person 2
            Person p2 = new Person();
            System.Console.WriteLine("Person 2: ");

            p2.InputPersonData();           //input person firstName, LastName, and age?

            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            if (maritalStatus)      //if married then create invoke methode, creat new person spouse
                {
                p2.SpouseInputData();
                }
            System.Console.WriteLine();

            p1.PrintNameandAge();           //invoke method PrintNameandAge() for person 1 and spouse if applicable
            p2.PrintNameandAge();           //invoke method PrintNameandAge() for person 1 and spouse if applicable
            System.Console.WriteLine("The Average Age of these people is " + Person.SumOfAllAges / Person.count + " years old.");
            System.Console.WriteLine();
            
            
            System.Console.WriteLine();
            System.Console.WriteLine("Select any key to complete...");
            System.Console.ReadKey();
        }
    }
}
