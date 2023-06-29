using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

class Program
{
    static void Main(string[] args)
    {
        IPizza pizza = new Pizza();

        Console.WriteLine(pizza.Options());
        Console.WriteLine($"Preço R$ {pizza.Price()}\n");
        Console.WriteLine("Tecle algo para aplicar o padrão decorator");
        Console.ReadKey();

        Console.WriteLine("-------- Aplicando o padrão Decorator ----------");

        IPizza pizza2 = new Pizza();
        IPizza especialDough = new EspecialDoughDecorator(pizza2);
        IPizza baconDecorator = new BaconDecorator(especialDough);
        IPizza borderDecorator = new FilledDoughDecorator(baconDecorator);

        Console.WriteLine(borderDecorator.Options());
        Console.WriteLine($"Preço Total R$: {borderDecorator.Price()}\n");
        Console.ReadKey();
    }
}