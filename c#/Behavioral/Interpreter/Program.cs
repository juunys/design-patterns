using Interpreter.AbstractExpression;
using Interpreter.Context;
using Interpreter.Expression;

class Program
{
    static void Main(string[] args)
    {
        List<IAbstractExpression> expressions = new List<IAbstractExpression>();

        Ctx context = new Ctx(DateTime.Now);
        Console.WriteLine($"Data atual : {context.Date}\n");

        Console.WriteLine("Selecione a expressão a usar : MM-DD-YYYY ou YYYY-MM-DD ou DD-MM-YYYY");

        context.Expression = Console.ReadLine().ToUpper();

        string[] format = context.Expression.Split("-");

        foreach (var item in format)
        {
            if (item == "DD")
            {
                expressions.Add(new DayExpression());
            }
            else if (item == "MM")
            {
                expressions.Add(new MonthExpression());
            }
            else if (item == "YYYY")
            {
                expressions.Add(new YearExpression());
            }
        }

        expressions.Add(new Separator());

        foreach (var obj in expressions)
        {
            obj.Evaluate(context);
        }

        Console.WriteLine($"\nData na expressão escolhida : {context.Expression}");

        Console.ReadLine();
    }
}