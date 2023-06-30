using System;
namespace Interpreter.Context
{
	public class Ctx
	{
		public string Expression { get; set; }
		public DateTime Date { get; set; }

		public Ctx(DateTime date)
		{
			Date = date;
		}
	}
}

