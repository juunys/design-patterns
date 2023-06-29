using System;
namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaCalabresa: Pizza
    {
        public PizzaCalabresa() : base("Pizza calabresa", Enums.DoughType.Pizza)
        {
            Ingredients.Add("Calabresa em cubos e tomate em cubos");
        }
    }
}

