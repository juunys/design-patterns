using System;
namespace Adapter.Target
{
	public interface ITarget
	{
		void ProcessMonthlyPaymentCalculation(string[,] studentsArray);
	}
}

