﻿namespace Assignment5
{
    class Course
    {
        public string cName;
        public int crnNumber;
        public int totalStudents;

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

        public void printCourseInfo()
        {
            System.Console.WriteLine("The Course Title is " + cName);
            System.Console.WriteLine("The Course Number is " + crnNumber);
            System.Console.WriteLine("There are " + totalStudents + " students in the Course.");
        }
    }
}