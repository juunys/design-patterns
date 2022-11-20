package creator

import (
	c "github.com/juunys/creational/factory-method/product"
)

type AK47Factory struct{}

func NewAK47Factory() GunFactory {
	return &AK47Factory{}
}

func (a *AK47Factory) FactoryMethod() c.GunProduct {
	return c.NewAK47()
}
