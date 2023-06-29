using System;
using Composite.Component;

namespace Composite.Leaf
{
	public class Employee : HourWorked
	{

		public int Id { get; set; }
		public int Hours { get; set; }
		public override int GetHourWorked()
		{
			Console.WriteLine($"O funcionáriop {Id} - {Name} registrou {Hours} trabalhadas.");
			return Hours;
		}

		public Employee()
		{
		}
	}
}

