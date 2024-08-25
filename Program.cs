using ChallengeApp1;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Eryk", "Turliñski", 20);
        Employee employee2 = new Employee("Kuba", "So³up", 21);
        Employee employee3 = new Employee("Damian", "Kajrewski", 19);

        employee1.AddScore(5);
        employee1.AddScore(2);
        employee1.AddScore(7);
        employee1.AddScore(6);
        employee1.AddScore(3);

        employee2.AddScore(1);
        employee2.AddScore(4);
        employee2.AddScore(6);
        employee2.AddScore(5);
        employee2.AddScore(3);

        employee3.AddScore(3);
        employee3.AddScore(5);
        employee3.AddScore(4);
        employee3.AddScore(8);
        employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
   {
       employee1, employee2, employee3
   };

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    { 
    EmployeeWithMaxResult = employee;
    }
}
Console.WriteLine("Imiê: " + EmployeeWithMaxResult.Name);
Console.WriteLine("Nazwisko: " + EmployeeWithMaxResult.Last_Name);
Console.WriteLine("Wynik: " + EmployeeWithMaxResult.Age);
Console.WriteLine("Wynik: " + EmployeeWithMaxResult.Result);