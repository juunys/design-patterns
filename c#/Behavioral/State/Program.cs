using State.Context;

class Program
{
    static void Main(string[] args)
    {
        CashMachine cashMachine = new CashMachine();
        Console.WriteLine("Estado atual do Caixa eletrônico : " + cashMachine.cashMachineState.GetType().Name);

        Console.WriteLine();
        cashMachine.InformPassword();
        cashMachine.WithdrawMoney();
        cashMachine.EjectCard();
        cashMachine.InsertCard();
        Console.WriteLine();

        Console.WriteLine("Estado atual do Caixa eletrônico : " + cashMachine.cashMachineState.GetType().Name);
        Console.WriteLine();

        cashMachine.InformPassword();
        cashMachine.WithdrawMoney();
        cashMachine.InsertCard();
        cashMachine.EjectCard();
        Console.WriteLine();

        Console.WriteLine("Estado atual do Caixa eletrônico : " + cashMachine.cashMachineState.GetType().Name);
        Console.Read();
    }
}