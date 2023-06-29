using System;
namespace Prototype.ConcretePrototype
{
	public class Soldier : ICloneable
	{
		public string Name { get; set; }
		public string Gun { get; set; }
		public Acessory Acessory { get; set; }

		public Soldier() { }
		public Soldier(Soldier s)
		{
			this.Name = s.Name;
			this.Gun = s.Gun;
			this.Acessory = s.Acessory;
		}

		public object Clone()
		{
			Soldier soldier = (Soldier)this.MemberwiseClone();
			soldier.Acessory = (Acessory)this.Acessory.Clone();
			return soldier;
		}
	}
}

