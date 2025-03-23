using ChallangeApp1;

Console.WriteLine("Witamy w Programie do oceny Pracowników");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

var employee = new EmployeeInFile("Eryk", "Turliński");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
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
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");