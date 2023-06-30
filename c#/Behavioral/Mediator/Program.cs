using Mediator.Colleague;
using Mediator.ConcreteColleague;
using Mediator.ConcreteMediator;
using Mediator.Mediator;

class Program
{
    static void Main(string[] args)
    {
        FacebookGroupMediator facebookGroupMediator = new ConcreteFacebookGroupMediator();

        User jane = new ConcreteUser(facebookGroupMediator, "Jane");
        User poppins= new ConcreteUser(facebookGroupMediator, "Poppins");
        User mary = new ConcreteUser(facebookGroupMediator, "Mary");

        facebookGroupMediator.RegisterUser(jane);
        facebookGroupMediator.RegisterUser(poppins);
        facebookGroupMediator.RegisterUser(mary);

        jane.Send("Teremos uma live sobre odontologia na próxima terça!");

        poppins.Send("Onde posso assistir?");

        jane.Send("No Youtube");

        Console.Read();
    }
}