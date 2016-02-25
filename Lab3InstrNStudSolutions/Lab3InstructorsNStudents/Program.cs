u
namespace Lab3InstructorsNStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            bool interum;
            
            //Create instructors and course taught
            Instructor inst001 = new Instructor("John", "English");
            Instructor inst002 = new Instructor("Mike", "Math");

            //Create students and add grades and Teacher's name
            Student stdnt001 = new Student("Jane", "John");
            Student stdnt002 = new Student("Joe", "John");
            Student stdnt003 = new Student("Melissa", "Mike");
            Student stdnt004 = new Student("Matt", "Mike");

            System.Console.Write("Would you like to see you grade? ");
            //System.Console.Read()  bool
            
        }
    }
}