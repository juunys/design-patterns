using System;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
	public abstract class DoughAbstractFactory
	{
		public abstract BaseDough CreateDough(DoughType doughType);

		public static DoughAbstractFactory CreateDoughFactory(DoughType doughType)
		{
			switch(doughType)
			{
				case DoughType.Pizza:
				{
					return new PizzaFactory();
				}
				case DoughType.Cake:
				{
					return new CakeFactory();
				}
				default:
					throw new ArgumentOutOfRangeException(nameof(doughType), doughType, null);
			}
		}
	}
}

