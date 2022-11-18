package main

type NormalBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func newNormalBuilder() *NormalBuilder {
	return &NormalBuilder{}
}

func (b *NormalBuilder) setWindowType() {
	b.windowType = "Wooden window"
}

func (b *NormalBuilder) setDoorType() {
	b.doorType = "Wooden door"
}

func (b *NormalBuilder) setNumFloorType() {
	b.floor = 1
}

func (b *NormalBuilder) getHouse() House {
	return House{
		doorType:   b.doorType,
		windowType: b.windowType,
		floor:      b.floor,
	}
}
