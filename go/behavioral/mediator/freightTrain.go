package main

import (
	"fmt"
)

type FreightTrain struct {
	mediator Mediator
}

func NewFreightTrain(mediator Mediator) *FreightTrain {
	return &FreightTrain{
		mediator: mediator,
	}
}

func (g *FreightTrain) Arrive() {
	if !g.mediator.CanArrive(g) {
		fmt.Println("FreightTrain: Arrival blocked, waiting")
		return
	}
	fmt.Println("FreightTrain: Arrived")
}

func (g *FreightTrain) Depart() {
	fmt.Println("FreightTrain: Leaving")
	g.mediator.NotifyAboutDeparture()
}

func (g *FreightTrain) PermitArrival() {
	fmt.Println("FreightTrain: Arrival permitted")
	g.Arrive()
}
