using System;
namespace Prototype.ConcretePrototype
{
	public class Acessory
	{
		public string Name { get; set; }

		public object Clone()
		{
			return (Acessory)this.MemberwiseClone();
		}
	}
}

