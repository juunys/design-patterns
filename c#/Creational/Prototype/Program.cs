using Prototype.ConcretePrototype;

namespace Prototype_DeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.Name = "Soldado1";
            soldier.Gun = "AK-47";
            soldier.Acessory = new Acessory { Name = "Visão Noturna" };

            //object clone1
            Soldier soldier_clone1 = (Soldier)soldier.Clone();
            soldier_clone1.Name = "Soldado clone1";
            soldier_clone1.Gun = "Kalashinikov";
            soldier_clone1.Acessory.Name = "Colete especial";

            //object clone 2
            Soldier soldier_clone2 = (Soldier)soldier.Clone();
            soldier_clone2.Name = "Soldado clone2";
            soldier_clone2.Gun = "M4A1";
            soldier_clone2.Acessory.Name = "Silenciador";

            //show original object
            Console.WriteLine(">> Original object");
            Console.WriteLine($"{soldier.Name} - {soldier.Gun}");
            Console.WriteLine($"{soldier.Acessory.Name} \n");

            //clone1
            Console.WriteLine(">> Clone1 object");
            Console.WriteLine($"{soldier_clone1.Name} - {soldier_clone1.Gun}");
            Console.WriteLine($"{soldier_clone1.Acessory.Name} \n");

            //clone2
            Console.WriteLine(">> Clone2 object");
            Console.WriteLine($"{soldier_clone2.Name} - {soldier_clone2.Gun}");
            Console.WriteLine($"{soldier_clone2.Acessory.Name} \n");

            Console.ReadLine();
        }
    }
}