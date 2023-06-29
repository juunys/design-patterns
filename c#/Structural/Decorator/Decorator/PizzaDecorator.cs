using System;
using Decorator.Component;

namespace Decorator.Decorator
{
	public class PizzaDecorator : IPizza
	{
		private readonly IPizza _pizza;
		public PizzaDecorator(IPizza pizza)
		{
			_pizza = pizza;
		}

		public virtual decimal Price()
		{
			var price = _pizza.Price();
			return price;
		}

		public virtual string Options()
		{
			var pizza = _pizza.Options();
			return pizza;
		}
	}
}

