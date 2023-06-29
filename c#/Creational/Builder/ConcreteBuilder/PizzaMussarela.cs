using System;
using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public override void PrepareDough()
        {
            pizza.DoughType = DoughType.Grossa;
            pizza.BorderType = BorderType.Normal;
            pizza.Size = Size.Grande;
        }

        public override void IncludeIngredients()
        {
            pizza.Ingredients = new List<string>
            {
                "Mussarela",
                "Molho de tomate",
                "Óregano",
            };
        }
    }
}

