﻿u
namespace Lab3InstructorsNStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool interum;
            
            //Create instructors and course taught
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            //Create students and add grades and Teacher's name
            Student Jane = new Student("Jane", "John");
            Student Joe = new Student("Joe", "John");
            Student Melissa = new Student("Melissa", "Mike");
            Student Matt = new Student("Matt", "Mike");

            //System.Console.Write("Would you like to see you grade? ");
            //System.Console.Read()  bool
            
        }
    }
}