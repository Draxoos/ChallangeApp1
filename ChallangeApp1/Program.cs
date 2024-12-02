using ChallengeApp1;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

var employee = new Employee();

try
{
    Employee emp = null;
    var name = emp.Surname;
}
catch(Exception)
{
    Console.WriteLine("Tego nie powinno być");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    { 
    break;
    }
    
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception e )
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Max}");