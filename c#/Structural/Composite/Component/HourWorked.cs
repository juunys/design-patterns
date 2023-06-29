using System;
namespace Composite.Component
{
	public abstract class HourWorked
    {
		public HourWorked()
		{
		}

		public string Name { get; set; }
		public abstract int GetHourWorked();

		public virtual void Add(HourWorked component)
		{
			throw new NotImplementedException();
		}

		public virtual void Remove(HourWorked component)
		{
			throw new NotImplementedException();
		}
	}
}

