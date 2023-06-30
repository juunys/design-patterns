using System;
using State.State;

namespace State.ConcreteState
{
    public class CardInsertedState : ICashMachineState
    {
        public void EjectCard()
        {
            Console.WriteLine("O cartão foi ejectado com sucesso");
        }

        public void InformPassword()
        {
            Console.WriteLine("A senha foi inserida com sucesso");
        }

        public void InsertCard()
        {
            Console.WriteLine("Operação inválida. O Cartão foi inserido");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("O saque foi realizado com sucesso");
        }
    }
}

