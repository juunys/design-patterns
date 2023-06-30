using Command.ConcreteCommand;
using Command.Invoker;
using Command.Receiver;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Padrão Command ##\n");

        Chef chef = new Chef();

        Order order = new Order(chef, "dish");
        Waiter waiter = new Waiter(order);
        waiter.Execute();

        order = new Order(chef, "dessert");
        waiter = new Waiter(order);
        waiter.Execute();

        Console.ReadKey();
    }
}