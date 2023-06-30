using Proxy.Domain;
using Proxy.Proxy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Exemplo de implementação do padrão Proxy ###\n");

        // developer access
        Console.WriteLine("\nFuncionário com perfil 'Programador' acessando a Shared Folder Proxy");

        Employee emp1 = new Employee("Jane", "123456", "developer");
        SharedFolderProxy proxyFolder1 = new SharedFolderProxy(emp1);
        proxyFolder1.ReadAndWriteOperation();

        // user access
        Console.WriteLine("\nFuncionário com perfil 'Usuário' acessando a Shared Folder Proxy");

        Employee emp2 = new Employee("Poppins", "123456", "user");
        SharedFolderProxy proxyFolder2 = new SharedFolderProxy(emp2);
        proxyFolder2.ReadAndWriteOperation();

        // ceo access
        Console.WriteLine("\nFuncionário com perfil 'CEO' acessando a Shared Folder Proxy");

        Employee emp3 = new Employee("Mary", "123456", "ceo");
        SharedFolderProxy proxyFolder3 = new SharedFolderProxy(emp3);
        proxyFolder3.ReadAndWriteOperation();

        Console.Read();
    }
}