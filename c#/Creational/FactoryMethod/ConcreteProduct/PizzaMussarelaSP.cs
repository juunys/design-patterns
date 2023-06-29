namespace FactoryMethod
{
    // Concrete product
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Name = "Pizza Mussarela Paulista";
            dough = "Massa fina crocante";
            sauce = "Molho de tomate italiano";
            ingredients.Add("Queijo parmesão");
            ingredients.Add("Azeitonas verdes");
        }
    }
}