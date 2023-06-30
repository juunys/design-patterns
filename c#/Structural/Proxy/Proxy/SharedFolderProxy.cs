using System;
using Proxy.Domain;
using Proxy.RealSubject;
using Proxy.Subject;

namespace Proxy.Proxy
{
	public class SharedFolderProxy : ISharedFolder
	{
		private ISharedFolder folder;
		private Employee employee;

		public SharedFolderProxy(Employee emp)
		{
			employee = emp;
		}

		public void ReadAndWriteOperation()
		{
			if (employee.Profile.ToUpper() == "CEO")
			{
				folder = new SharedFolder();
				Console.WriteLine("O proxy 'Shared Folder' invoca a pasta Real" +
					" : método usado : ReadAndWriteOperation()");
				folder.ReadAndWriteOperation();
			}
			else
			{
				Console.WriteLine("O proxy 'Shared Folder' avisa : 'Você não tem permissão para acessar esta pasta'\n");
			}
		}
	}
}

