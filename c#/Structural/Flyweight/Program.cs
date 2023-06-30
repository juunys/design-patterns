using Flyweight.ConcreteFlyweight;
using Flyweight.ShapeFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n### Círculos Amarelos");
        for (int i = 0; i < 3; i++)
        {
            var circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Amarelo");
            circle.Draw();
        }
        Console.WriteLine("\n### Círculos Verdes");
        for (int i = 0; i < 3; i++)
        {
            var circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Verde");
            circle.Draw();
        }
        Console.WriteLine("\n### Círculos Azuis");
        for (int i = 0; i < 3; i++)
        {
            var circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Azul");
            circle.Draw();
        }
        Console.WriteLine("\n### Círculos Vermelhos");
        for (int i = 0; i < 3; i++)
        {
            var circle = (Circle)ShapeFactory.GetShape("circle");
            circle.SetColor("Vemelho");
            circle.Draw();
        }

        Console.ReadKey();
    }
}