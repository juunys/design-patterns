using System;
using Flyweight.Flyweight;

namespace Flyweight.ConcreteFlyweight
{
	public class Circle : IShape
	{
		// extrinsic state
		public string Color { get; set; }
		// intrinsic state (cache)
		private int x = 10;
		private int y = 20;
		private int radius = 30;

		public void SetColor(string Color)
		{
			this.Color = Color;
		}

		public void Draw()
		{
			Console.WriteLine($"Círculo: [Cor:{Color} x:{x},y:{y}, raio:{radius}]");
		}
	}
}

