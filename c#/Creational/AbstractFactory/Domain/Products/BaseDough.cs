using System.Collections;
using AbstractFactory.Domain.Enums;

namespace AbstractFactory.Domain.Products
{
	public abstract class BaseDough
	{
		public DoughType DoughType { get; set; }
		public string Name { get; set; }
		public ArrayList Ingredients = new ArrayList();

		public BaseDough(string name, DoughType type)
		{
			Name = name;
			DoughType = type;
		}
	}
}

