namespace FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza BuildPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}