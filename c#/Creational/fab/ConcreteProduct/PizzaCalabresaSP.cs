namespace FactoryMethod
{
    // Concrete product
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Name = "Pizza Calabresa Paulista com muita calabresa";
            dough = "Massa fina crocante";
            sauce = "Molho de tomate italiano";
            ingredients.Add("Fatias de calabresa defumada especial");
            ingredients.Add("Queijo parmesão italiano tradicional");
        }
    }
}