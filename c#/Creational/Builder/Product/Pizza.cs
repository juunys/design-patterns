using System;
namespace Builder.Product
{
	public class Pizza
	{
		public DoughType DoughType { get; set; }
		public BorderType BorderType { get; set; }
		public Size Size { get; set; }
		public List<string> Ingredients { get; set; }

		public void PizzaContent()
		{
			Console.WriteLine($"Pizza com massa : {DoughType}");
            Console.WriteLine($"Pizza com borda: {BorderType}");
            Console.WriteLine($"Pizza tamanho : {Size}");
            Console.WriteLine($"Pizza com ingredientes : ");
			foreach(string ingredient in Ingredients)
			{
				Console.WriteLine($" {ingredient}");
			}
        }
	}
}

