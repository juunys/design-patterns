using System;
namespace AbstractFactory.Domain.Products
{
	public class OrangeCake : Cake
    {
		public OrangeCake() : base("Bolo de laranja", Enums.DoughType.Cake)
        {
            Ingredients.Add("Com cobertura de calda de laranja");
        }
    }
}

