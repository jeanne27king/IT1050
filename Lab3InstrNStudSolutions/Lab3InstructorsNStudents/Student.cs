namespace Lab3InstructorsNStudents
{
    public class Student
    {
        private string Name;
        private int Grade = 0;
        private string Teacher; 

        public Student (string stdntname, string stdntteacher)
        {
            this.Name = stdntname;
            this.Teacher = stdntteacher;
        }

        //public int SetGrade(int grade)
        //{
        //    this.Grade = grade; 
        //}

        //public string PrintStudentInfo()
        //{
        //    System.Console.Write(Name + " has a " + this.Grade + " and is taught by " + this.Teacher);
        //    System.Console.ReadKey();
        //}
    }
}