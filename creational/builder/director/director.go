package director

import (
	b "github.com/juunys/creational/builder/builder"
	m "github.com/juunys/creational/builder/model"
)

type HouseDirector struct {
	builder b.HouseBuilder
}

func NewDirector(b b.HouseBuilder) *HouseDirector {
	return &HouseDirector{
		builder: b,
	}
}

func (d *HouseDirector) SetBuilder(b b.HouseBuilder) {
	d.builder = b
}

func (d *HouseDirector) BuildHouse() m.House {
	d.builder.SetDoorType()
	d.builder.SetNumFloorType()
	d.builder.SetWindowType()
	return d.builder.GetHouse()
}
