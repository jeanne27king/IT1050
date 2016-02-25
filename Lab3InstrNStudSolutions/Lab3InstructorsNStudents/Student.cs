namespace Lab3InstructorsNStudents
{
    class Student
    {
        private string Name = null;
        private int Grade = 0;
        private string Teacher = null; 

        public Student (string name, string teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
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