package model

import "fmt"

// concrete product
type Gun struct {
	Name  string
	Power int
}

func (g *Gun) SetName(name string) {
	g.Name = name
}

func (g *Gun) SetPower(power int) {
	g.Power = power
}

func (g *Gun) GetName() string {
	return g.Name
}

func (g *Gun) GetPower() int {
	return g.Power
}

func (g *Gun) String() string {
	return fmt.Sprintf("Gun: %s\nPower: %d\n",
		g.Name,
		g.Power,
	)
}
