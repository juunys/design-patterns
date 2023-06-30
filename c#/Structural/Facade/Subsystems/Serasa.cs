using System;
namespace Facade.Subsystems
{
	public class Serasa
	{
		public bool IsInSerasa(Client client)
		{
			Console.WriteLine("Verificando SERASA do cliente " + client.Name);
			return false;
		}
	}
}

