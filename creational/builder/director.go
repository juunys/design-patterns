package main

type Director struct {
	builder Builder
}

func NewDirector(b Builder) *Director {
	return &Director{
		builder: b,
	}
}

func (d *Director) setBuilder(b Builder) {
	d.builder = b
}

func (d *Director) buildHouse() House {
	d.builder.setDoorType()
	d.builder.setNumFloorType()
	d.builder.setWindowType()
	return d.builder.getHouse()
}
