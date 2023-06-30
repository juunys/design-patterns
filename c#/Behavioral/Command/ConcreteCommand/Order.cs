using System;
using Command.Receiver;
using Command.Command;


namespace Command.ConcreteCommand
{
	public class Order : Cmd
    {
		private Chef Chef { get; set; }
		private string Action { get; set; }

		public Order(Chef chef, string action)
		{
			Chef = chef;
			Action = action;
		}

		public override void Execute()
		{
			if (Action.Equals("dish"))
			{
				Chef.PreparingDish();
			}
			else
			{
				Chef.PreparingDessert();
			}
		}
	}
}

