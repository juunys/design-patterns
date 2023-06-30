using System;
using Interpreter.AbstractExpression;
using Interpreter.Context;

namespace Interpreter.Expression
{
	public class MonthExpression : IAbstractExpression
    {
        public void Evaluate(Ctx context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}

