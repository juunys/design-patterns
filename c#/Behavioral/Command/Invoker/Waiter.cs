using System;
using Command.ConcreteCommand;

namespace Command.Invoker
{
	public class Waiter
	{
		private Order _order;

		public Waiter(Order order)
		{
			_order = order;
		}

		public void Execute()
		{
			_order.Execute();
		}
	}
}

