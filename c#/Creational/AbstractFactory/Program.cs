using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;
using AbstractFactory.Factory.AbstractFactory;

// factories
var cakeFactory = DoughAbstractFactory.CreateDoughFactory(DoughType.Cake);
var pizzaFactory = DoughAbstractFactory.CreateDoughFactory(DoughType.Pizza);

// create cake objects
var cake1 = cakeFactory.CreateDough((DoughType)CakeType.Chocolate);
var cake2 = cakeFactory.CreateDough((DoughType)CakeType.Orange);

// create pizza objects
var pizza1 = pizzaFactory.CreateDough((DoughType)PizzaType.Mussarela);
var pizza2 = pizzaFactory.CreateDough((DoughType)PizzaType.Calabresa);

// show details
ShowDetails(cake1);
ShowDetails(cake2);
ShowDetails(pizza1);
ShowDetails(pizza2);

Console.ReadLine();

static void ShowDetails(BaseDough baseDough)
{
    Console.WriteLine($"Tipo : {baseDough.DoughType}");
    Console.WriteLine(baseDough.Name);
    Console.WriteLine(baseDough.Ingredients[0].ToString());
    Console.WriteLine("\n");
}