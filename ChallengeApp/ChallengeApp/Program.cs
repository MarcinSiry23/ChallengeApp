﻿using ChallengeApp;

Console.WriteLine("Welcome to the Grade Employee App");
Console.WriteLine("=======================================");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Your grade: ");
    var input = Console.ReadLine();
    if (input == "")
    {
        break;
    }
    employee.AddGrade(input);
    Console.WriteLine("Press \"enter\" to get statistic");
    Console.WriteLine("--------------------------------");
}

var statistic = employee.GetStatistics();

Console.WriteLine($"\nAverage grades: {statistic.Average:N2}");
Console.WriteLine($"Minimum grade: {statistic.Min:N2}");
Console.WriteLine($"Maximal grade: {statistic.Max:N2}");
Console.WriteLine($"Average letter grade: {statistic.AverageLetter}");