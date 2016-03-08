namespace Lab3
{
    public class Student
    {
        private string SName;
        private Instructor Instrctr;
        private int Grade=0;

        public Student(string stname, Instructor instrctr)
        {
            this.Instrctr = instrctr;
            this.SName = stname;
        }

        public void SetStudentGrade(int grade)
        {
            this.Grade = grade;
        }

        public void PrintStudentInfo()
        {
            System.Console.WriteLine("My Name is " + this.SName + ".");
            this.Instrctr.PrintInstructorInfo();
            System.Console.WriteLine(" and I have a " + this.Grade + ".");
            System.Console.WriteLine();

        }
    }
}