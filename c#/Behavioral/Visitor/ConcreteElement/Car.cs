using System;
using Visitor.Element;
using Visitor.Visitor;

namespace Visitor.ConcreteElement
{
	public class Car : IStore
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Model { get; set; }

		public void Visit(IVisitor visitor)
		{
			visitor.Accept(this);
		}
	}
}

