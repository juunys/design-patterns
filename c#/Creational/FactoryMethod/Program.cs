namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== PIZZARIA =====================\n");
            Console.WriteLine("Infome o local (S)São Paulo ou (R)Rio de Janeiro");
            var placeChosen = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza (M)Mussarela ou (C)Calabresa");
            var pizzaChosen = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CreatePizzaria(placeChosen);
                var pizza = pizzaria.BuildPizza(pizzaChosen);

                Console.WriteLine(pizza.Prepare());
                Console.WriteLine("\nPizza concluída com sucesso");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}