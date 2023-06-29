package main

import (
	"fmt"

	"github.com/juunys/structural/flyweight/factory"
	m "github.com/juunys/structural/flyweight/model"
)

func main() {
	game := m.NewGame()

	// Add terrorist
	game.AddTerrorist()
	game.AddTerrorist()
	game.AddTerrorist()
	game.AddTerrorist()

	//Add CounterTerrorist
	game.AddCounterTerrorist()
	game.AddCounterTerrorist()
	game.AddCounterTerrorist()

	dressFactoryInstance := factory.GetDressFactorySingleInstance()

	for dressType, dress := range dressFactoryInstance.DressMap {
		fmt.Printf("DressColorType: %s\nDressColor: %s\n", dressType, dress.GetColor())
	}

}
