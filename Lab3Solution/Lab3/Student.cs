namespace Lab3
{
    public class Student
    {
        private string Name;
        private string Instrctr;
        private int Grade=0;

        public Student(string stname, string stinstructor)
        {
            this.Name = stname;
            this.Instrctr = stinstructor;
        }

        public void SetStudentGrade(int grade)
        {
            this.Grade = grade;
        }

        public void PrintStudentInfo()
        {
            string instname = this.Instrctr;
            System.Console.WriteLine("My Name is " + this.Name);
            Instructor.PrintInstructorInfo(this.Instrctr);
            System.Console.WriteLine(" and I have a " + this.Grade);
            System.Console.WriteLine();

        }
    }
}