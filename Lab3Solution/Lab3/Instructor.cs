namespace Lab3
{
    public class Instructor
    {
        private string IName;
        private string CourseName;

        public Instructor(string instName, string instCourseName)
        {
            this.IName = instName;
            this.CourseName = instCourseName;
        }

        public void StudentGrade(Student stname, int grade)
        {
            stname.SetStudentGrade(grade);
        }

        public void PrintInstructorInfo(Instructor instname)
        {
           return this.IName + " and they teach "+ this.CourseName);
        }
    }
}
