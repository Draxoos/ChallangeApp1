using ChallengeApp1;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    { 
    break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Max}");