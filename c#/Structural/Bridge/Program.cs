using Bridge.ConcreteImplementor;
using Bridge.Domain;
using Bridge.RefinedAbstraction;

class Program
{
    static void Main(string[] args)
    {
        CalculateSalary calculateSalary = new CalculateSalary(new GenerateXML());

        Employee employee = new Employee
        {
            Id = 101,
            Name = "Jane",
            BaseSalary = 10000,
            Incentive = 5000
        };

        calculateSalary.ProcessEmployeeSalary(employee);

        employee.Incentive = 5500;

        calculateSalary = new CalculateSalary(new GenerateJson());

        calculateSalary.ProcessEmployeeSalary(employee);

        Console.ReadKey();
    }
}