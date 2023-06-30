using System;
using State.ConcreteState;
using State.State;

namespace State.Context
{
	public class CashMachine : ICashMachineState
	{
		public ICashMachineState cashMachineState { get; set; }

		public CashMachine()
		{
			cashMachineState = new CardNotInsertedState();
		}

		public void InsertCard()
		{
			cashMachineState.InsertCard();

			if (cashMachineState is CardNotInsertedState)
			{
				cashMachineState = new CardInsertedState();
				Console.WriteLine("O estado interno do caixa eletrônico foi alterado para : " + cashMachineState.GetType().Name);
			}
		}

		public void EjectCard()
		{
			cashMachineState.EjectCard();
            if (cashMachineState is CardInsertedState)
            {
                cashMachineState = new CardNotInsertedState();
                Console.WriteLine("O estado interno do caixa eletrônico foi alterado para : " + cashMachineState.GetType().Name);
            }
        }

		public void InformPassword()
		{
			cashMachineState.InformPassword();
		}

		public void WithdrawMoney()
		{
			cashMachineState.WithdrawMoney();
		}
	}
}

