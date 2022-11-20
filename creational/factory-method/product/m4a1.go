package product

import (
	m "github.com/juunys/creational/factory-method/model"
)

// concrete gun - embed gun struct and indirectly implement all GunProduct methods.
type M4A1 struct {
	m.Gun
}

func (g *M4A1) SetName(name string) {
	g.Name = name
}

func (g *M4A1) SetPower(power int) {
	g.Power = power
}

func (g *M4A1) GetName() string {
	return g.Name
}

func (g *M4A1) GetPower() int {
	return g.Power
}

func NewM4A1() GunProduct {
	return &M4A1{
		Gun: m.Gun{
			Name:  "M4A1",
			Power: 247,
		},
	}
}
