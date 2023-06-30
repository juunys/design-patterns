using System;
using Interpreter.Context;

namespace Interpreter.AbstractExpression
{
	public interface IAbstractExpression
	{
		void Evaluate(Ctx context);
	}
}

