using System;
using Memento.Caretaker;

namespace Memento.Memento
{
	public class Mt : ICareTaker, IOriginator
	{
		private int firstNumber;
		private int secondNumber;

		public Mt(int number1, int number2)
		{
			firstNumber = number1;
			secondNumber = number2;
		}

		public int GetFirstNumber()
		{
			return firstNumber;
		}

		public int GetSecondNumber()
		{
			return secondNumber;
		}
	}
}

