using System;
using Mediator.Colleague;
using Mediator.Mediator;

namespace Mediator.ConcreteColleague
{
	public class ConcreteUser : User
	{
		public ConcreteUser(FacebookGroupMediator mediator, string name) : base(mediator, name)
		{
		}

		public override void Receive(string msg)
		{
			Console.WriteLine($"{name} : recebida <= {msg}");
		}

		public override void Send(string msg)
		{
			Console.WriteLine($"\n{name} : enviada => {msg}\n");
			mediator.SendMessage(msg, this);
		}
	}
}

