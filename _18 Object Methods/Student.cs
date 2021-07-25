namespace Object_Methods
{
    public class Student
    {
        public string Name;
        public double AverageGrade;

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        public bool GreatStudent()
        {
            if (AverageGrade > 8)
            {
                return true;
            }

            return false;
        }
    }
}