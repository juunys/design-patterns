using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
	public class FilledDoughDecorator : PizzaDecorator
	{
		public FilledDoughDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Options()
        {
            var pizza = base.Options();
            pizza += "\r\n com borda recheada";
            return pizza;
        }

        public override decimal Price()
        {
            var price = base.Price();
            price += 3.00M;
            return price;
        }
    }
}

