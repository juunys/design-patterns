package model

import (
	d "github.com/juunys/structural/flyweight/factory"
	f "github.com/juunys/structural/flyweight/flyweight"
)

type Player struct {
	Dress      f.Dress
	PlayerType string
	Lat        int
	Long       int
}

func NewPlayerTerrorist() *Player {
	dress := d.GetDressFactorySingleInstance().GetDressTerrorist()
	return &Player{
		PlayerType: "T",
		Dress:      dress,
	}
}

func NewPlayerCounterTerrorist() *Player {
	dress := d.GetDressFactorySingleInstance().GetDressCounterTerrorist()
	return &Player{
		PlayerType: "CT",
		Dress:      dress,
	}
}

func (p *Player) NewLocation(lat, long int) {
	p.Lat = lat
	p.Long = long
}
