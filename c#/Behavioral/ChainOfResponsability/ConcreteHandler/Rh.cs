using System;
using ChainOfResponsability.Handler;

namespace ChainOfResponsability.ConcreteHandler
{
	public class Rh : Authorizer
	{
        private int REMIT_DAYS = 30;

        public override void AuthorizeLicense(string name, int days)
        {
            if (days <= REMIT_DAYS)
            {
                AproveLicense(name, days);
            }
            else
            {
                Console.WriteLine($"\n Não foi possível autorizar a licença de {days} para {name}.\n *** Comunique a Diretoria");
            }
        }

        private void AproveLicense(string name, int days)
        {
            Console.WriteLine($"O Setor de RH aprovou {days} dias de licença remunerada para : {name}\n");
        }
    }
}

