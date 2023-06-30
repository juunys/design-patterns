using System;
using Facade.Subsystems;

namespace Facade.Facade
{
	public class MyFacade
	{
		private CreditLimit limit;
		private Serasa serasa;
		private Cadin cadin;
		private Register register;

		public MyFacade()
		{
			limit = new CreditLimit();
			serasa = new Serasa();
			cadin = new Cadin();
			register = new Register();
		}

		public bool GrantLoan(Client client, double value)
		{
			Console.WriteLine($"{client.Name} esta pleitando um empréstimo no valor de {value:C}\n");
			register.RegisterClient(client);

			bool GrantLoan = true;
			if (serasa.IsInSerasa(client))
			{
				Console.WriteLine($"Cliente {client.Name} possui restrição no SERASA");
				GrantLoan = false;
			}
			else if (cadin.IsInCadin(client))
			{
				Console.WriteLine($"Cliente {client.Name} possui restrição no CADIN");
				GrantLoan = false;
			}
			else if (!limit.HasCreditLimit(client, value))
			{
                Console.WriteLine($"O cliente {client.Name} possui limite de crédito inferior a {value:C}");
                GrantLoan = false;
            }

			return GrantLoan;
		}
	}
}

