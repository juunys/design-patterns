using Prototype.ConcretePrototype;
using static System.Console;

namespace Prototype_DeepCopy
{
    class Program
    {
        public static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.Name = "Soldado 1";
            soldier.Gun = "AK-47";
            soldier.Acessory = new Acessory { Name = "Visão noturna" };

            //object clone1
            Soldier soldier_clone1 = (Soldier)soldier.Clone();
            soldier_clone1.Name = "Soldado clone1";
            soldier_clone1.Gun = "M4A1";
            soldier_clone1.Acessory.Name = "Gás de pimenta";

            Soldier soldier_clone2 = (Soldier)soldier.Clone();
            soldier_clone2.Name = "Soldado clone2";
            soldier_clone2.Gun = "SCAR";
            soldier_clone2.Acessory.Name = "Silenciador";

            //show original object
            WriteLine(">> Objeto original");
            WriteLine($"{soldier.Name} - {soldier.Gun}");
            WriteLine($"{soldier.Acessory.Name} \n");

            //show object clone 1
            WriteLine(">> Objeto Clone1");
            WriteLine($"{soldier_clone1.Name} - {soldier_clone1.Gun}");
            WriteLine($"{soldier_clone1.Acessory.Name} \n");

            //show object clone 2
            WriteLine(">> Objeto Clone2");
            WriteLine($"{soldier_clone2.Name} - {soldier_clone2.Gun}");
            WriteLine($"{soldier_clone2.Acessory.Name} \n");

            ReadLine();
        }
    }
}