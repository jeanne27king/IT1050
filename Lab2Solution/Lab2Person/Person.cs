namespace Lab2Person
{
    class Person
    {
        //Member variable declaration
        public int Age = 0;
        public string firstName;
        public string lastName;
        public Person Spouse;
        public static double SumOfAllAges = 0;
        public static int count=0;

        public void InputPersonData()      //invoke method input person firstName, lastName, and age?
        {
            System.Console.Write("What is your first name? ");
            this.firstName = System.Console.ReadLine();
            System.Console.Write("What is your last name? ");
            this.lastName = System.Console.ReadLine();
            System.Console.Write("What is your age? ");
            this.Age = int.Parse(System.Console.ReadLine());
            this.Spouse = null;
            SumOfAllAges += this.Age;
            count++;
        }

        public void SpouseInputData()  //invoke method input spouse name and age and set last name
        {
            this.Spouse = new Person();
            System.Console.Write("What is your spouse's first name? ");
            this.Spouse.firstName = System.Console.ReadLine();
            System.Console.Write("What is your spouse's age? ");
            this.Spouse.Age = int.Parse(System.Console.ReadLine());
            this.Spouse.lastName = this.lastName;
            this.Spouse.Spouse = this;
            SumOfAllAges += this.Spouse.Age;
            count++;   
        }

        public string GetFullName()  //invoke method GetFullName
        { 
            return this.firstName + " " + this.lastName; 
        }

        public void PrintNameandAge()   //invoke method print name and age of people
        {
            System.Console.WriteLine(this.GetFullName() + " is " + this.Age + " years old.");
            if (this.Spouse !=null)     //print name and age of spouse if there is a spouse (spouse not null)
                {
                System.Console.WriteLine(this.Spouse.GetFullName() + " is " + this.Spouse.Age + " years old.");
                }
            else
                { 
                System.Console.WriteLine(this.GetFullName() + " does not have a spouse.");
                }
        }
    }
}
