package creator

import (
	c "github.com/juunys/creational/factory-method/product"
)

type M4A1Factory struct{}

func NewM4A1Factory() GunFactory {
	return &M4A1Factory{}
}

func (m *M4A1Factory) FactoryMethod() c.GunProduct {
	return c.NewM4A1()
}
