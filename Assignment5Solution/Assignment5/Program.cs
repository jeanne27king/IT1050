namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;              //Total # of Students returned to the main program
            bool q = true;      //while loop condition

            //Create a new Course
            Course c1 = new Course();
            c = c1.getCourseInfo();         //Total Students return value
            System.Console.WriteLine();

            Student[] arrayofStudents;
            arrayofStudents = new Student[c];

            //Enter Student Information.  Check to reenter
            while (q == true)
            {

                for (int i = 0; i < c; i++)
                {
                    arrayofStudents[i] = new Student();
                    System.Console.Write("Student Name: ");
                    arrayofStudents[i].sName = System.Console.ReadLine();

                    System.Console.Write("Student Number: ");
                    arrayofStudents[i].sNumber = int.Parse(System.Console.ReadLine());
                    System.Console.WriteLine();
                }
                System.Console.Write("True or False:  Would you like to reenter the student information? ");
                q = bool.Parse(System.Console.ReadLine());
                System.Console.WriteLine();
            }

            //Print Course Information
            c1.printCourseInfo();
            System.Console.WriteLine();

            //Print Student Information
            for (int i = 0; i < c; i++)
            {
                System.Console.Write("Student Name: " + arrayofStudents[i].sName + ", ");
                System.Console.WriteLine("Student Number: " + arrayofStudents[i].sNumber);
            }

            System.Console.Write("Press any key to complete...");
            System.Console.ReadKey();

        }
    }
}