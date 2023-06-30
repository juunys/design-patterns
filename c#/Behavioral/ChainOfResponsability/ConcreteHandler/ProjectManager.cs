using System;
using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
	public class ProjectManager : Authorizer
	{
		private int REMIT_DAYS = 5;

		public override void AuthorizeLicense(string name, int days)
		{
			if (days <= REMIT_DAYS)
			{
				AproveLicense(name, days);
			}
			else
			{
				_authorizer?.AuthorizeLicense(name, days);
			}
		}

		private void AproveLicense(string name, int days)
		{
			Console.WriteLine($"O Gerente de Projeto aprovou {days} dias de licença remunerada para : {name}\n");
		}
	}
}

