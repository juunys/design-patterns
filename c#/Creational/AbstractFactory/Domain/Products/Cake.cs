using System;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public abstract class Cake : BaseDough
	{
		public Cake(string name, DoughType type) : base(name, type)
		{
		}
	}
}

