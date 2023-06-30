using System;
using Memento.Caretaker;
using Memento.Memento;

namespace Memento.Originator
{
	public class Calculator : ICalculator
	{
		private int firstNumber;
		private int secondNumber;

		public ICareTaker BackupLastCalculation()
		{
			return new Mt(firstNumber, secondNumber);
		}

		public int GetCalculationResult()
		{
			return firstNumber + secondNumber;
		}

		public void RestoreLastCalculation(ICareTaker memento)
		{
			firstNumber = ((IOriginator)memento).GetFirstNumber();
			secondNumber = ((IOriginator)memento).GetSecondNumber();
        }

		public void SetFirstNumber(int num1)
		{
			firstNumber = num1;
		}

        public void SetSecondNumber(int num2)
        {
            secondNumber = num2;
        }

    }
}

