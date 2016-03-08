namespace Lab3
{
    public class Instructor
    {
        private string IName;
        private string CourseName;

        public Instructor(string iname, string instcoursname)
        {
            this.IName = iname;
            this.CourseName = instcoursname;
        }

        public void StudentGrade(Student stname, int grade)
        {
            stname.SetStudentGrade(grade);
        }

        public void PrintInstructorInfo()
        {
            System.Console.Write("My " + this.CourseName + " Instructor is " + this.IName);
        }
    }
}
