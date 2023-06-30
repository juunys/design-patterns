using System;
namespace Proxy.Domain
{
	public class Employee
	{
		public string Name { get; set; }
		public string Password { get; set; }
		public string Profile { get; set; }

		public Employee(string name, string password, string profile)
		{
			Name = name;
			Password = password;
			Profile = profile;
		}
	}
}

