package main

import (
	"fmt"
)

type PassengerTrain struct {
	mediator Mediator
}

func NewPassengerTrain(mediator Mediator) *PassengerTrain {
	return &PassengerTrain{
		mediator: mediator,
	}
}

func (g *PassengerTrain) Arrive() {
	if !g.mediator.CanArrive(g) {
		fmt.Println("PassengerTrain: Arrival blocked, waiting")
		return
	}
	fmt.Println("PassengerTrain: Arrived")
}

func (g *PassengerTrain) Depart() {
	fmt.Println("PassengerTrain: Leaving")
	g.mediator.NotifyAboutDeparture()
}

func (g *PassengerTrain) PermitArrival() {
	fmt.Println("PassengerTrain: Arrival permitted, arriving")
	g.Arrive()
}
