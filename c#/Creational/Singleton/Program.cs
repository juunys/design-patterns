namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => ThreadAccess1(),
                () => ThreadAccess2()
            );
            Console.ReadLine();
        }

        private static void ThreadAccess1()
        {
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Thread 1");
        }

        private static void ThreadAccess2()
        {
            Singleton s2 = Singleton.Instance;
            Console.WriteLine("Thread 2");
        }
    }
}
