using System;
using Proxy.Subject;

namespace Proxy.RealSubject
{
	public class SharedFolder : ISharedFolder
	{
		public void ReadAndWriteOperation()
		{
			Console.WriteLine("### Operação de Leitura e Escrita " +
				"na pasta compartilhada ###");
		}
	}
}

