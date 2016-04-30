namespace Assignment5
{
    class Course
    {
        public string cName;
        public int crnNumber;
        public int totalStudents;

        //Enter Course Information
        public int getCourseInfo()
        {
            System.Console.Write("What is the name of your Course: ");
            cName = System.Console.ReadLine();
            System.Console.Write("What is the Course Number: ");
            crnNumber = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many students are in the class: ");
            totalStudents = int.Parse(System.Console.ReadLine());
            return totalStudents;
        }

        //Print Course Information
        public void printCourseInfo()
        {
            System.Console.WriteLine("Course Title:  " + cName);
            System.Console.WriteLine("Course Number:  " + crnNumber);
            System.Console.WriteLine("Total Students:  " + totalStudents);
        }
    }
}