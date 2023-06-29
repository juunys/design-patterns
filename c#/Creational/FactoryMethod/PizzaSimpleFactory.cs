namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CreatePizzaria(string place)
        {
            PizzaFactoryMethod pizzaria;
            switch (place)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRJ();
                    break;
                default:
                    throw new ApplicationException("A pizzaria {place} não existe.");
            }

            return pizzaria;
        }
    }
}