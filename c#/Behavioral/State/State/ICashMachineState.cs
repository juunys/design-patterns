using System;
namespace State.State
{
	public interface ICashMachineState
	{
		void InsertCard();
		void EjectCard();
		void InformPassword();
		void WithdrawMoney();
	}
}

