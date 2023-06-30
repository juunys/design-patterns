using System;
using Memento.Caretaker;

namespace Memento.Originator
{
	public interface ICalculator
	{
		// create memento
		ICareTaker BackupLastCalculation();

		// set memento
		void RestoreLastCalculation(ICareTaker memento);

		// originator
		int GetCalculationResult();
		void SetFirstNumber(int num1);
		void SetSecondNumber(int num2);
	}
}

