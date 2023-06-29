using Composite.Composite;
using Composite.Leaf;

class Program
{
    static void Main(string[] args)
    {
        Organization organization = new Organization { Name = "TECH 2P" };
        Organization departmentIT = new Organization { Name = " TI " };
        departmentIT.Add(new Employee { Id = 1001, Name = "Jane", Hours = 8 });
        departmentIT.Add(new Employee { Id = 1002, Name = "Peter", Hours = 6 });
        departmentIT.Add(new Employee { Id = 1005, Name = "Bob", Hours = 7 });

        Organization deparmentContability = new Organization { Name = " Contabilidade " };
        deparmentContability.Add(new Employee { Id = 1003, Name = "Vania", Hours = 5 });
        deparmentContability.Add(new Employee { Id = 1004, Name = "Luiz", Hours = 6 });

        organization.Add(departmentIT);
        organization.Add(deparmentContability);
        organization.GetHourWorked();

        Console.ReadKey();
    }
}