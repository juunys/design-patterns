using System;
using State.State;

namespace State.ConcreteState
{
	public class CardNotInsertedState : ICashMachineState
	{
		public void EjectCard()
		{
			Console.WriteLine("Não é possível ejectar o cartão. O cartão não foi inserido");
		}

		public void InformPassword()
		{
			Console.WriteLine("Não é possível informar a senha. Insira o cartão");
		}

		public void InsertCard()
		{
			Console.WriteLine("Cartão inserido com sucesso");
		}

		public void WithdrawMoney()
		{
			Console.WriteLine("Não é possível realizar o saque. Insira o cartão");
		}
	}
}

