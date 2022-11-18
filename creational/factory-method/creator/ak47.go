package creator

import (
	p "github.com/juunys/creational/factory-method/product"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type AK47 struct {
	p.Gun
}

func NewAK47() p.GunProduct {
	return &AK47{
		Gun: p.Gun{
			Name:  "AK47",
			Power: 300,
		},
	}
}
