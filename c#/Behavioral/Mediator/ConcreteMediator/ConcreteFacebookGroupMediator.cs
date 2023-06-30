using System;
using Mediator.Colleague;
using Mediator.Mediator;

namespace Mediator.ConcreteMediator
{
	public class ConcreteFacebookGroupMediator : FacebookGroupMediator
	{
		private List<User> usersList = new List<User>();

		public void RegisterUser(User user)
		{
            usersList.Add(user);
		}

		public void SendMessage(string message, User user)
		{
			foreach (var u in usersList)
			{
				if (u != user)
				{
					u.Receive(message);
				}
			}
		}
	}
}

