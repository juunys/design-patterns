package model

import "fmt"

// concrete product
type Gun struct {
	Name  string
	Power int
}

func (g *Gun) String() string {
	return fmt.Sprintf("Gun: %s\nPower: %d\n",
		g.Name,
		g.Power,
	)
}
