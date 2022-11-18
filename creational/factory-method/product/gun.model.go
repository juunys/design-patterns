package product

import "fmt"

// concrete product
type Gun struct {
	Name  string
	Power int
}

func (g *Gun) setName(name string) {
	g.Name = name
}

func (g *Gun) setPower(power int) {
	g.Power = power
}

func (g *Gun) getName() string {
	return g.Name
}

func (g *Gun) getPower() int {
	return g.Power
}

func (g *Gun) String() string {
	return fmt.Sprintf("Gun: %s\nPower: %d\n",
		g.Name,
		g.Power,
	)
}
