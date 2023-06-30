using System;
using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
	public class Supervisor : Authorizer
	{
        private int REMIT_DAYS = 15;

        public override void AuthorizeLicense(string name, int days)
        {
            if (days <= REMIT_DAYS)
            {
                AproveLicense(name, days);
            }
            else
            {
                _authorizer?.AuthorizeLicense(name, days);
            }
        }

        private void AproveLicense(string name, int days)
        {
            Console.WriteLine($"O Supervisor da equipe aprovou {days} dias de licença remunerada para : {name}\n");
        }
    }
}

