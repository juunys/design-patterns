using System;
using Mediator.Colleague;

namespace Mediator.Mediator
{
	public interface FacebookGroupMediator
	{
		void SendMessage(string msg, User user);
		void RegisterUser(User user);
	}
}

