using System;
using Flyweight.ConcreteFlyweight;
using Flyweight.Flyweight;

namespace Flyweight.ShapeFactory
{
	public class ShapeFactory
	{
		private static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

		public static IShape GetShape(string key)
		{
			IShape shape;
			if (shapes.ContainsKey(key))
			{
				return shapes[key];
			}
			else
			{
				if (key == "circle")
				{
					shape = new Circle();
					shapes.Add("circle", shape);
				}
				else
				{
					throw new Exception("Este tipo de objeto não pode ser criado");
				}
			}
			return shape;
		}
	}
}

