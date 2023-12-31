namespace ChallengeApp
{
    public class Employee
    { 
        //list
        private List<float> grades = new List<float>();

        //constructor
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        //property
        public string Name { get; private set; }

        public string Surname { get; private set; }

        //method
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <=100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"\"{grade}\" is invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else 
            { 
                Console.WriteLine($"String value \"{grade}\" is not correct"); 
            }
        }

        public void AddGrade(double grade)
        {
            float castDoubleToFloat = (float)grade;
            this.AddGrade(castDoubleToFloat);
        }

        public void AddGrade(long grade)
        {
            float castDoubleToFloat = (float)grade;
            this.AddGrade(castDoubleToFloat);
        }

        public void AddGrade(char grade)
        {
            if (float.TryParse(grade.ToString(), out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"Char value \"{grade}\" is not correct");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}
