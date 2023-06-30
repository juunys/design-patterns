using System;
using Interpreter.AbstractExpression;
using Interpreter.Context;

namespace Interpreter.Expression
{
	public class Separator : IAbstractExpression
    {
        public void Evaluate(Ctx context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace(" ", "-");
        }
    }
}

