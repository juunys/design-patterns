using System;
namespace ChainOfResponsability.Handler
{
	public abstract class Authorizer
	{
		protected Authorizer _authorizer;

		public void NextAuthorizor(Authorizer authorizer)
		{
			_authorizer = authorizer;
		}

		public abstract void AuthorizeLicense(string name, int days);
	}
}

