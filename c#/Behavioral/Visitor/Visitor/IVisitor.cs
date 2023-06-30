using System;
using Visitor.ConcreteElement;

namespace Visitor.Visitor
{
	public interface IVisitor
	{
		void Accept(Car car);
	}
}

