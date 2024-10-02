using ChallengeApp1;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Eryk");
Employee employee2 = new Employee("Kuba");
Employee employee3 = new Employee("Damian");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(1);
employee1.AddScore(6);
employee1.AddScore(4); //23

employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(6); //26

employee3.AddScore(9);
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
Console.WriteLine("Wynik: " + EmployeeWithMaxResult.Result);