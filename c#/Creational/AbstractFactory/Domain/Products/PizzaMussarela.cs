using System;
namespace AbstractFactory.Domain.Products
{
	public sealed class PizzaMussarela : Pizza
	{
		public PizzaMussarela() : base("Pizza mussarela", Enums.DoughType.Pizza)
		{
			Ingredients.Add("Queijo mussarela gratinado e molho de tomate");
		}
	}
}

