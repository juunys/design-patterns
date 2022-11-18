package creator

import (
	p "github.com/juunys/creational/factory-method/product"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type M4A1 struct {
	p.Gun
}

func NewM4A1() p.GunProduct {
	return &M4A1{
		Gun: p.Gun{
			Name:  "M4A1",
			Power: 247,
		},
	}
}
