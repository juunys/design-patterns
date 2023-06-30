using System;
using Observer.Observer;
using Observer.Subject;

namespace Observer.ConcreteObserver
{
	public class ConcreteObserver : IObserver
	{
		public string User { get; set; }

		public ConcreteObserver(string name, ISubject subject)
		{
			User = name;
			subject.RegisterObserver(this);
		}

		public void Update(string availability)
		{
			Console.WriteLine($"Olá {User}, o Produto que você deseja agora está {availability} em nosso site.");
		}
	}
}

