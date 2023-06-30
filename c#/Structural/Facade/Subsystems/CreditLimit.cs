using System;
namespace Facade.Subsystems
{
	public class CreditLimit
	{
		public bool HasCreditLimit(Client client, double value)
		{
			Console.WriteLine("Verificando o limite de crédito do cliente " + client.Name);

			if (value > 200000.00)
				return false;
			else
				return true;
		}
	}
}

