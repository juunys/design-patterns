using System;
using Observer.ConcreteObserver;
using Observer.Observer;
using Observer.Subject;

namespace Observer.ConcreteSubject
{
	public class ConcreteSubject : ISubject
	{
		private List<IObserver> observers = new List<IObserver>();
		private string Product { get; set; }
		private int Price { get; set; }
		private string Availability { get; set; }

		public ConcreteSubject(string product, int price, string status)
		{
			Product = product;
			Price = price;
			Availability = status;
		}

		public string GetAvailability()
		{
			return Availability;
		}

		public void SetAvailability(string status)
		{
			this.Availability = status;
			Console.WriteLine("A disponibilidade mudou de 'Sem estoque' para 'Disponível'");
			NotifyObservers();
		}

		public void RegisterObserver(IObserver observer)
		{
			observers.Add(observer);
		}

		public void AddObservers(IObserver observer)
		{
			observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			Console.WriteLine($"O Produto : {Product} no valor de R$ {Price} agora está disponível." +
				"\n ### Notificando todos os observers registrados ###");

			Console.WriteLine();

			foreach(IObserver observer in observers)
			{
				observer.Update(Availability);
			}
		}
	}
}

