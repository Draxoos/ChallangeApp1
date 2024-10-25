using ChallengeApp1;

var employee = new Employee("Eryk", "Turliński");
employee.AddGrade(5);
employee.AddGrade(7);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");