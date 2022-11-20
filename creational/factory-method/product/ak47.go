package product

import (
	m "github.com/juunys/creational/factory-method/model"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type AK47 struct {
	m.Gun
}

func (g *AK47) SetName(name string) {
	g.Name = name
}

func (g *AK47) SetPower(power int) {
	g.Power = power
}

func (g *AK47) GetName() string {
	return g.Name
}

func (g *AK47) GetPower() int {
	return g.Power
}

func NewAK47() GunProduct {
	return &AK47{
		Gun: m.Gun{
			Name:  "AK47",
			Power: 300,
		},
	}
}
