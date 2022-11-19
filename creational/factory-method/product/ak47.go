package product

import (
	i "github.com/juunys/creational/factory-method/interface"
	m "github.com/juunys/creational/factory-method/model"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type AK47 struct {
	m.Gun
}

func NewAK47() i.GunProduct {
	return &AK47{
		Gun: m.Gun{
			Name:  "AK47",
			Power: 300,
		},
	}
}
