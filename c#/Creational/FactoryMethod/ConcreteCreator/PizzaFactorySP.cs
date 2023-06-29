namespace FactoryMethod
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("M"))
            {
                return new PizzaMussarelaSP();
            }
            else if (type.Equals("C"))
            {
                return new PizzaCalabresaSP();
            }
            else return null;
        }
    }
}