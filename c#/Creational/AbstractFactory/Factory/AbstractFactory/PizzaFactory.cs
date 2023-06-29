using System;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class PizzaFactory : DoughAbstractFactory
    {
        public override BaseDough CreateDough(DoughType doughType)
        {
            var pizzaType = (PizzaType)doughType;

            switch (pizzaType)
            {
                case PizzaType.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case PizzaType.Calabresa:
                    {
                        return new PizzaCalabresa();
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Tipo não implementado");
                    }
            }
        }
    }
}

