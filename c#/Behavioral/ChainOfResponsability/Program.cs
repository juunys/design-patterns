using ChainOfResponsability.ConcreteHandler;

class Program
{
    static void Main(string[] args)
    {
        ProjectManager pm = new ProjectManager();
        Supervisor sup = new Supervisor();
        Rh rh = new Rh();

        pm.NextAuthorizor(sup);
        sup.NextAuthorizor(rh);

        pm.AuthorizeLicense("Jane", 9);
        pm.AuthorizeLicense("Poppins", 14);
        pm.AuthorizeLicense("Mary", 18);
        pm.AuthorizeLicense("Jun", 30);
        pm.AuthorizeLicense("Tony", 50);
    }
}