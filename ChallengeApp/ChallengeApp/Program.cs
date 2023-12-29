using ChallengeApp;

var employee = new Employee("Marcin", "Siry");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(6);
var statistic = employee.GetStatistics();
Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Average: {statistic.Min:N2}");
Console.WriteLine($"Average: {statistic.Max:N2}");