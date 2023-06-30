using System;
using Visitor.ConcreteElement;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitor
{
	public class VisitorPrice : IVisitor
	{
		private const int CAR_DISCOUNT = 12;

        public void Accept(Car car)
        {
            decimal priceCarAfterDiscount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);

            Console.WriteLine($"{car.Model} {car.Name} : ${priceCarAfterDiscount}");
        }
    }
}

