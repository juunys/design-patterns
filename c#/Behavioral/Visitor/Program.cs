using Visitor.ConcreteElement;
using Visitor.ConcreteVisitor;
using Visitor.Element;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Padrão Visitor ###");

        List<Car> cars = new List<Car>();
        cars.Add(new Car() { Name = "A1", Price = 2000M, Model = "Mercedes" });
        cars.Add(new Car() { Name = "458", Price = 3500M, Model = "Ferrari" });
        cars.Add(new Car() { Name = "911", Price = 2800M, Model = "Porsche" });

        List<IStore> stores = new List<IStore>();

        Console.WriteLine("Preços normais dos carros/n");
        foreach(var car in cars)
        {
            Console.WriteLine($" {car.Model} {car.Name} : ${car.Price}");
            stores.Add(car);
        }

        Console.WriteLine("Preços dos carros com desconto/n");
        Console.WriteLine("Aplicando o padrão Visitor");
        Console.WriteLine("Tecle algo...");

        Console.ReadLine();
        Console.WriteLine("Novos Preços com desconto de 12%\n");

        VisitorPrice visitorPrice = new VisitorPrice();
        foreach(var element in stores)
        {
            element.Visit(visitorPrice);
        }

        Console.ReadLine();
    }
}