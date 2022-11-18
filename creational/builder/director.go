package main

type HouseDirector struct {
	builder HouseBuilder
}

func NewDirector(b HouseBuilder) *HouseDirector {
	return &HouseDirector{
		builder: b,
	}
}

func (d *HouseDirector) setBuilder(b HouseBuilder) {
	d.builder = b
}

func (d *HouseDirector) buildHouse() House {
	d.builder.setDoorType()
	d.builder.setNumFloorType()
	d.builder.setWindowType()
	return d.builder.getHouse()
}
