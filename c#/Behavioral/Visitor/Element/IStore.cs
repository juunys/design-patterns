using System;
using Visitor.Visitor;

namespace Visitor.Element
{
	public interface IStore
	{
		void Visit(IVisitor visitor);
	}
}

