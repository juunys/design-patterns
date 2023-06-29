using Builder.ConcreteBuilder;
using Builder.Director;

internal class Program
{
    private static void Main(string[] args)
    {
        // Director
        var pizzaria = new Pizzaria(new PizzaCalabresa());
        pizzaria.BuildPizza();
        var pizza1 = pizzaria.GetPizza();
        pizza1.PizzaContent();

        pizzaria = new Pizzaria(new PizzaMussarela());
        pizzaria.BuildPizza();
        var pizza2 = pizzaria.GetPizza();
        pizza2.PizzaContent();

        Console.ReadKey();
    }
}