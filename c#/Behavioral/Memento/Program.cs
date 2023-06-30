using Memento.Caretaker;
using Memento.Originator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Padrão Memento ###\n");
        Console.WriteLine("Calcula a soma de dois numeros e armazena o estado");
        Console.WriteLine("Pressione algo para realizar o calculo");

        ICalculator calculator = new Calculator();

        calculator.SetFirstNumber(10);
        calculator.SetSecondNumber(100);

        Console.WriteLine($"### Estado 1 : {calculator.GetCalculationResult()}");

        ICareTaker memento = calculator.BackupLastCalculation();
        Console.ReadKey();

        Console.WriteLine("\nCalcula uma nova soma de dois numeros \n");

        calculator.SetFirstNumber(17);
        calculator.SetSecondNumber(-290);

        Console.WriteLine($"Estado 2 : {calculator.GetCalculationResult()}");
        Console.WriteLine("\nRestaura o resultado da soma anterior");

        calculator.RestoreLastCalculation(memento);

        Console.WriteLine($"### Estado 1 : {calculator.GetCalculationResult()}");

        Console.ReadKey();
    }
}