package product

import (
	i "github.com/juunys/creational/factory-method/interface"
	m "github.com/juunys/creational/factory-method/model"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type M4A1 struct {
	m.Gun
}

func NewM4A1() i.GunProduct {
	return &M4A1{
		Gun: m.Gun{
			Name:  "M4A1",
			Power: 247,
		},
	}
}
