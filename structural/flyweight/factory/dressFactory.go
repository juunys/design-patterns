package factory

import (
	"github.com/juunys/structural/flyweight/flyweight"
)

const (
	//TerroristDressType terrorist dress type
	TerroristDressType = "tDress"
	//CounterTerrroristDressType terrorist dress type
	CounterTerrroristDressType = "ctDress"
)

var (
	dressFactorySingleInstance = &DressFactory{
		DressMap: make(map[string]flyweight.Dress),
	}
)

type DressFactory struct {
	DressMap map[string]flyweight.Dress
}

func (d *DressFactory) GetDressTerrorist() flyweight.Dress {
	if d.DressMap[TerroristDressType] == nil {
		d.DressMap[TerroristDressType] = flyweight.NewTerroristDress()
	}

	return d.DressMap[TerroristDressType]
}

func (d *DressFactory) GetDressCounterTerrorist() flyweight.Dress {
	if d.DressMap[CounterTerrroristDressType] == nil {
		d.DressMap[CounterTerrroristDressType] = flyweight.NewCounterTerroristDress()
	}

	return d.DressMap[CounterTerrroristDressType]
}

func GetDressFactorySingleInstance() *DressFactory {
	return dressFactorySingleInstance
}
