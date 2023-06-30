using System;
namespace Facade.Subsystems
{
	public class Cadin
	{
		public bool IsInCadin(Client client)
		{
			Console.WriteLine("Verificando o CADIN para o cliente " + client.Name);
			return false;
		}
	}
}

