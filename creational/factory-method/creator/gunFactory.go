package creator

import (
	c "github.com/juunys/creational/factory-method/product"
)

type GunFactory interface {
	FactoryMethod() c.GunProduct
}
