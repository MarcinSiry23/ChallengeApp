﻿namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        //list
        private List<float> grades = new List<float>();

        //constructor
        public Supervisor(string name, string surname)
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
            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    AddGrade(15);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
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