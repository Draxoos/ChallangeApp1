using ChallengeApp1;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Eryk", "Turliñski", 20, 0);
        Employee employee2 = new Employee("Kuba", "So³up", 21, 0);
        Employee employee3 = new Employee("Damian", "Kajrewski", 19, 0);

        employee1.AddScore(5);
        employee1.AddScore(2);
        employee1.AddScore(7);
        employee1.AddScore(6);
        employee1.AddScore(4); //23

        employee2.AddScore(1);
        employee2.AddScore(8);
        employee2.AddScore(3);
        employee2.AddScore(5);
        employee2.AddScore(6); //26

        employee3.AddScore(3);
        employee3.AddScore(5);
        employee3.AddScore(2);
        employee3.AddScore(4);
        employee3.AddScore(3); //17

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
    maxResult = employee.Result;
    EmployeeWithMaxResult = employee;
    }
}
Console.WriteLine("Imiê: " + EmployeeWithMaxResult.Name);
Console.WriteLine("Nazwisko: " + EmployeeWithMaxResult.Last_Name);
Console.WriteLine("Wiek: " + EmployeeWithMaxResult.Age);
Console.WriteLine("Wynik: " + EmployeeWithMaxResult.Result);