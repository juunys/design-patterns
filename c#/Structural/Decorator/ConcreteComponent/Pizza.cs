using System;
using Decorator.Component;

namespace Decorator.ConcreteComponent
{
	public class Pizza : IPizza
	{
		public decimal Price()
		{
			var price = 10.00M;
			return price;
		}

		public string Options()
		{
			var pizza = "Pizza padrão ou normal";
			return pizza;
		}
	}
}

