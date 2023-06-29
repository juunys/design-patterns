using System;
using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
	public class EspecialDoughDecorator : PizzaDecorator
	{
		public EspecialDoughDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string Options()
        {
            var pizza = base.Options();
            pizza += "\r\n com borda especial";
            return pizza;
        }

        public override decimal Price()
        {
            var price = base.Price();
            price += 5.00M;
            return price;
        }
    }
}

