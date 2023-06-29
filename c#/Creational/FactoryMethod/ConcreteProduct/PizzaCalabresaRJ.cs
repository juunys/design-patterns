namespace FactoryMethod
{
    // Concrete product
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Name = "Pizza Calabresa Carioca";
            dough = "Massa fina crocante carioca";
            sauce = "Molho de tomate italiano";
            ingredients.Add("Fatias de calabresa especial");
            ingredients.Add("Queijo parmesão italiano tradicional");
        }
    }
}