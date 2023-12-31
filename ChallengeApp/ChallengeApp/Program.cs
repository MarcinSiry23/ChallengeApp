using ChallengeApp;

var employee = new Employee("Marcin", "Siry");
employee.AddGrade("asd");
employee.AddGrade("400");
employee.AddGrade("3");
employee.AddGrade("0.5");
employee.AddGrade("0,5");
employee.AddGrade(5);
employee.AddGrade(101);
employee.AddGrade(6.234);
employee.AddGrade('1');
employee.AddGrade('Z');
var statistic = employee.GetStatistics();
Console.WriteLine($"\nAverage grades: {statistic.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic.Max:N2}");
