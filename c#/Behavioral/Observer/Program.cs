using Observer.ConcreteSubject;
using Observer.ConcreteObserver;

class Program
{
    static void Main(string[] args)
    {
        ConcreteSubject IPhone14 = new ConcreteSubject("Iphone14 ", 7000, "Sem estoque");
        Console.WriteLine("IPhone 14 - estado atual : " + IPhone14.GetAvailability());

        Console.WriteLine("\nObservers inscritos para receber notificações sobre o produto IPhone 14\n");

        ConcreteObserver jane = new ConcreteObserver("Jane", IPhone14);
        ConcreteObserver poppins = new ConcreteObserver("Poppins", IPhone14);

        Console.WriteLine("\nPressione algo para alterar a disponibilidade e notificar os observers");

        Console.ReadKey();

        IPhone14.SetAvailability("Disponível");

        Console.Read();
    }
}