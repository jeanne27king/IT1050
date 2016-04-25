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

            Student[] arrayofStudents;
            arrayofStudents = new Student[c];

            while (q == true)
            {
                //Create an array of students in the class
                //arrayofStudents[c].enterStudentInfo();

                for (int i = 0; i < c; i++)
                {
                    arrayofStudents[i] = new Student();
                    System.Console.Write("Student Name: ");
                    arrayofStudents[i].sName = System.Console.ReadLine();

                    System.Console.Write("Student Number: ");
                    arrayofStudents[i].sNumber = int.Parse(System.Console.ReadLine());
                }
                System.Console.Write("True or False:  Would you like to reenter the class information? ");
                q = bool.Parse(System.Console.ReadLine());
            }

            //Print Course Information
            c1.printCourseInfo();

            //print Student Information
            //arrayofStudents[c].printStudentInfo(c);

            for (int i = 0; i < c; i++)
            {
                System.Console.Write("Student Name: " + arrayofStudents[i].sName + ", ");
                System.Console.WriteLine("Student Number: " + arrayofStudents[i].sNumber);
            }

            System.Console.ReadKey();

        }
    }
}