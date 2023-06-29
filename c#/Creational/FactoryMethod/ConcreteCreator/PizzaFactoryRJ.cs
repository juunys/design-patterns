namespace FactoryMethod
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("M"))
            {
                return new PizzaMussarelaRJ();
            }
            else if (type.Equals("C"))
            {
                return new PizzaCalabresaRJ();
            }
            else return null;
        }
    }
}