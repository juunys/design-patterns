using System;
namespace AbstractFactory.Domain.Products
{
	public sealed class ChocolateCake : Cake
	{
		public ChocolateCake() : base("Bolo de cholocate", Enums.DoughType.Cake)
		{
			Ingredients.Add("Com cobertura de chocolate Nestlé");
		}
	}
}

