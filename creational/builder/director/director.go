package director

import (
	i "github.com/juunys/creational/builder/interface"
	m "github.com/juunys/creational/builder/model"
)

type HouseDirector struct {
	builder i.HouseBuilder
}

func NewDirector(b i.HouseBuilder) *HouseDirector {
	return &HouseDirector{
		builder: b,
	}
}

func (d *HouseDirector) SetBuilder(b i.HouseBuilder) {
	d.builder = b
}

func (d *HouseDirector) BuildHouse() m.House {
	d.builder.SetDoorType()
	d.builder.SetNumFloorType()
	d.builder.SetWindowType()
	return d.builder.GetHouse()
}
