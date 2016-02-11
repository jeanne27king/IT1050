namespace Lab2Person
{
    class Person
    {
        //Member variable declaration
        public int Age = 0;
        public string firstName;
        public string lastName;
        public string spouseName;
        public Person Spouse;

        public void InputPersonData()        //invoke method input person firstName, LastName, and age?
        {
            System.Console.Write("What is your first name? ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            this.lastName = System.Console.ReadLine();
            System.Console.Write("What is your age? ");
            this.Age = int.Parse(System.Console.ReadLine());
            Age++;
        }

        public void SpouseInputData()  //invoke method input spouse name and age
        {
            System.Console.Write("What is your spouse's first name? ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("What is your spouse's age? ");
            this.Age = int.Parse(System.Console.ReadLine());
            Age++;     
        }

        public void PrintNameandAge()   //invoke print name and age?
        {
            System.Console.WriteLine(this.firstName + " " + this.lastName + " is " + this.Age + " years old.");
        }


        //public static int SumOfAllAges();
        //    return Age/4;


            

    }
}
