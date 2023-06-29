using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
	public class BaconDecorator : PizzaDecorator
	{
		public BaconDecorator(IPizza pizza) :base(pizza)
		{
		}

        public override string Options()
        {
            var pizza = base.Options();
            pizza += "\r\n com porção extra de bacon";
            return pizza;
        }

        public override decimal Price()
        {
            var price = base.Price();
            price += 4.00M;
            return price;
        }
    }
}

