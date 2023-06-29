using System;
using Builder.Product;

namespace Builder.Builder
{
	public abstract class PizzaBuilder
	{
		protected Pizza pizza;

		public void CreatePizza()
		{
			pizza = new Pizza();
		}

		public Pizza GetPizza()
		{
			return pizza;
		}

		public abstract void PrepareDough();

		public abstract void IncludeIngredients();
	}
}

