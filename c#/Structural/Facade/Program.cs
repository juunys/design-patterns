using Facade.Facade;
using Facade.Subsystems;

class Program
{
    static void Main(string[] args)
    {
        MyFacade grantCreditFacade = new MyFacade();

        Client client1 = new Client("Jane");

        bool result = grantCreditFacade.GrantLoan(client1, 199000.00);

        Console.WriteLine($"O empréstimo pleitado pelo cliente {client1.Name} foi " + (result ? "Aprovado" : "Recusado"));

        Console.ReadKey();
    }
}