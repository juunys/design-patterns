using Adapter.Adapter;
using Adapter.Target;

internal class Program
{
    private static void Main(string[] args)
    {
        string[,] studentsArray = new string[5, 4]
        {
            {"101", "Maria", "Artes", "1000"},
            {"102", "Jane", "Odonto", "2000"},
            {"103", "Tico", "Educação Física", "1500"},
            {"104", "Zezin", "Computação", "1400"},
            {"105", "Peter", "Medicina", "2500"},
        };

        ITarget target = new StudentAdapter();

        Console.WriteLine("SistemaMensalidades passa o " + "array de string para o Adapter\n");

        target.ProcessMonthlyPaymentCalculation(studentsArray);

        Console.ReadKey();
    }
}