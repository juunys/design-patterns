using Strategy.ConcreteStrategy;
using Strategy.Context;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("## Padrão Strategy ##\n");
        CompressionContext ctx = new CompressionContext(new RarCompression());

        Console.WriteLine("Informe o nome do arquivo a comprimir");
        var filename = Console.ReadLine();

        Console.WriteLine("\nInforme o tipo de compressão a ser usada");
        Console.WriteLine("1-Rar(Padrão) 2-Zip 3-Gzip\n");

        var option = Convert.ToInt32(Console.ReadLine());

        if (option == 2)
        {
            ctx.DefineStrategy(new ZipCompression());
        }
        else if (option == 3)
        {
            ctx.DefineStrategy(new GzipCompresion());
        }

        ctx.CreateCompressedFile(filename);

        Console.Read();
    }
}