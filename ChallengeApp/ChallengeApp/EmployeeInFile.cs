﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "gradess.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception($"\"{grade}\" is invalid grade value.");
            }
        }

        public override void AddGrade(string grade)
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

        public override void AddGrade(double grade)
        {
            float castDoubleToFloat = (float)grade;
            this.AddGrade(castDoubleToFloat);
        }

        public override void AddGrade(long grade)
        {
            float castLongToFloat = (float)grade;
            this.AddGrade(castLongToFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (char.ToUpper(grade))
            {
                case 'A':
                    AddGrade(100);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(40);
                    break;
                case 'E':
                    AddGrade(20);
                    break;
                case 'F':
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong letter.");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = this.CountStatistics(gradesFromFile);
            return statistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
