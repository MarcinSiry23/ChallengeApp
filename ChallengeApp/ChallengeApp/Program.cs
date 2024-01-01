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
var statistic1 = employee.GetStatisticsWithForEach();
var statistic2 = employee.GetStatisticsWithFor();
var statistic3 = employee.GetStatisticsWithDoWhile();
var statistic4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"\nAverage grades: {statistic.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic.Max:N2}");

//forech
Console.WriteLine("\nforech:");
Console.WriteLine($"Average grades: {statistic1.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic1.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic1.Max:N2}");

//for
Console.WriteLine("\nfor:");
Console.WriteLine($"Average grades: {statistic2.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic2.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic2.Max:N2}");

//do while
Console.WriteLine("\ndo while:");
Console.WriteLine($"Average grades: {statistic3.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic3.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic3.Max:N2}");

//while
Console.WriteLine("\nwhile:");
Console.WriteLine($"Average grades: {statistic4.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic4.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic4.Max:N2}");
