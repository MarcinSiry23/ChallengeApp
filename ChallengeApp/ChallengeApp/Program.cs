using ChallengeApp;

Employee employee1 = new Employee("Adam", "Kowalski", 32);
Employee employee2 = new Employee("Marcin", "Nowak", 27);
Employee employee3 = new Employee("Stefan", "Mazur", 45);

employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(1);

employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(4);

employee3.AddScore(2);
employee3.AddScore(7);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Employee with max score (" + maxResult + ") is " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " - " + employeeWithMaxResult.Age + "yers old.");