﻿using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    internal interface IEmployee
    {
        event GradeAddedDelegate GradeAdded;
        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);

        Statistics GetStatistics();


    }
}
