using System;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
	public sealed class CakeFactory : DoughAbstractFactory
	{
        public override BaseDough CreateDough(DoughType doughType)
        {
            var cakeType = (CakeType)doughType;

            switch(cakeType)
            {
                case CakeType.Chocolate:
                    {
                        return new ChocolateCake();
                    }
                case CakeType.Orange:
                    {
                        return new OrangeCake();
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("Tipo não implementado");
                    }
            }
        }
	}
}

