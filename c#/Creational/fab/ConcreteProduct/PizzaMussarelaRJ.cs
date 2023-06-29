namespace FactoryMethod
{
    // Concrete product
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Name = "Pizza Mussarela Carioca";
            dough = "Massa fina crocante carioca";
            sauce = "Molho de tomate carioca";
            ingredients.Add("Queijo parmesão ralado");
            ingredients.Add("Azeitonas pretas");
        }
    }
}