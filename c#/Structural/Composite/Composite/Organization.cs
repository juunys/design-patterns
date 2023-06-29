using System;
using Composite.Component;

namespace Composite.Composite
{
	public class Organization : HourWorked
	{
		protected List<HourWorked> departments = new List<HourWorked>();
		public override void Add(HourWorked component)
		{
			departments.Add(component);
		}
		public override void Remove(HourWorked component)
		{
			departments.Remove(component);
		}
		public override int GetHourWorked()
		{
			var hoursWorkedByDepartments = 0;
			foreach (var department in departments)
			{
				hoursWorkedByDepartments += department.GetHourWorked();
			}
			Console.WriteLine($"{Name} registrou um total de [{hoursWorkedByDepartments}] horas\n");
			return hoursWorkedByDepartments;
		}

		public Organization()
		{
		}
	}
}

