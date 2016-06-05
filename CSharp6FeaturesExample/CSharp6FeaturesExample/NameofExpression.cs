using static System.Console;

namespace CSharp6FeaturesExample
{
    class NameofExpression
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            WriteLine($"{nameof(Employee.Id)} : {emp.Id}");
            WriteLine($"{nameof(Employee.Name)} : {emp.Name}");
            WriteLine($"{nameof(Employee.Salary)} : {emp.Salary}");

            ReadLine();
        }

        class Employee
        {
            public int Id { get; set; } = 108;
            public string Name { get; set; } = "Raj";
            public int Salary { get; set; } = 15000;
        }

    }
}
