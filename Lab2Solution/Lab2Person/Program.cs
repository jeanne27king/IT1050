namespace Lab2Person
{
    class Program
    {
        static void Main(string[] args)
        {
            bool maritalStatus;


            //Person 1 
            Person p1 = new Person();
            System.Console.Write("Person 1: ");
            //input person firstName, LastName, and age?
            p1.InputPersonData();
            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            //if marital status is true then create new spouse?
            //input spouse firstName, set LastName, and age?
            Person p1spouse = new Person();
            p1spouse.SpouseInputData();
            p1spouse.lastName = p1.lastName;
            p1.spouseName = p1spouse.firstName;
            p1spouse.spouseName = p1.firstName;
            System.Console.WriteLine();


            //Person 2
            Person p2 = new Person();
            System.Console.Write("Person 2: ");
            //input person firstName, LastName, and age?
            p2.InputPersonData();
            System.Console.Write("True or False... Are you married? ");
            maritalStatus = bool.Parse(System.Console.ReadLine());
            //if marital status is true then create new spouse?
            //input spouse firstName, set LastName, and age?
            Person p2spouse = new Person();
            p2spouse.SpouseInputData();
            p2spouse.lastName = p2.lastName;
            p2.spouseName = p2spouse.firstName;
            p2spouse.spouseName = p2.firstName;
            System.Console.WriteLine();

            p1.PrintNameandAge();
            p1spouse.PrintNameandAge();
            p2.PrintNameandAge();
            p2spouse.PrintNameandAge();
            System.Console.WriteLine();

            //Invoke sum of all ages static method
            //SumofAllAges();

            System.Console.WriteLine();
            System.Console.WriteLine("Select any key to complete...");
            System.Console.ReadKey();
        }
    }
}
