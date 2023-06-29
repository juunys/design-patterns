using System;
using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
	public class Pizzaria
	{
		private readonly PizzaBuilder builder;
		public Pizzaria(PizzaBuilder builder)
		{
			this.builder = builder;
		}

		public void BuildPizza()
		{
			builder.CreatePizza();
			builder.PrepareDough();
			builder.IncludeIngredients();
		}

		public Pizza GetPizza()
		{
			return builder.GetPizza();
		}
	}
}

