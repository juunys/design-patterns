using System;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public abstract class Pizza : BaseDough
	{
		public Pizza(string name, DoughType type) : base(name, type)
		{
		}
	}
}

