using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        //list
        private List<float> grades = new List<float>();

        public Employee()
        {
        }

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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"\"{grade}\" is invalid grade value.");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length == 1)
            {
                AddGrade((char)grade[0]);
            }
            else
            {
                throw new Exception($"String value \"{grade}\" is not correct.");
            }
        }
        
        public void AddGrade(double grade)
        {
            float castDoubleToFloat = (float)grade;
            this.AddGrade(castDoubleToFloat);
        }

        public void AddGrade(long grade)
        {
            float castLongToFloat = (float)grade;
            this.AddGrade(castLongToFloat);
        }

        public void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                case 'F':
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Wrong letter.");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}
