using System;
namespace Facade.Subsystems
{
	public class Register
	{
		public void RegisterClient(Client client)
		{
			Console.WriteLine($"Cadastro do cliente {client.Name} concluído");
		}
	}
}

