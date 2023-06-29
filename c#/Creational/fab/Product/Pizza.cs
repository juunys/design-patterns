namespace FactoryMethod
{
    // Product
    public abstract class Pizza
    {
        protected string Name { get; set; };
        protected string dough;
        protected string sauce;
        protected ArrayList ingredients = new ArrayList();

        public string Prepare()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough + "\n");
            sb.Append(sauce + "\n");
            sb.Append("Ingredients: " + "\n");
            foreach (var ingredient in ingredients)
            {
                sb.Append("\t" + ingredient + "\n");
            }

            sb.Append(Cook());
            sb.Append(Slice());
            sb.Append(Pack());
            return sb.ToString();
        }

        public virtual string Cook()
        {
            return "Cozinhar por 30 minutos a 250 graus \n";
        }

        public virtual string Slice()
        {
            return "Fatiar a pizza em 8 pedaços \n";
        }

        public virtual string Pack()
        {
            return "Embalar a pizza com a embalagem oficial \n";
        }
    }
}