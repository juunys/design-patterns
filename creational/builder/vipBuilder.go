package main

type VipBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func newVipBuilder() *VipBuilder {
	return &VipBuilder{}
}

func (b *VipBuilder) setWindowType() {
	b.windowType = "Glass window"
}

func (b *VipBuilder) setDoorType() {
	b.doorType = "Glass door"
}

func (b *VipBuilder) setNumFloorType() {
	b.floor = 3
}

func (b *VipBuilder) getHouse() House {
	return House{
		doorType:   b.doorType,
		windowType: b.windowType,
		floor:      b.floor,
	}
}
