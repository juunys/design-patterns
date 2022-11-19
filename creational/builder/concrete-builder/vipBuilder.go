package concreteBuilder

import (
	"fmt"

	m "github.com/juunys/creational/builder/model"
)

type VipBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func NewVipBuilder() *VipBuilder {
	return &VipBuilder{}
}

func (b *VipBuilder) SetWindowType() {
	b.windowType = "Glass window"
}

func (b *VipBuilder) SetDoorType() {
	b.doorType = "Glass door"
}

func (b *VipBuilder) SetNumFloorType() {
	b.floor = 3
}

func (b *VipBuilder) GetHouse() m.House {
	return m.House{
		DoorType:   b.doorType,
		WindowType: b.windowType,
		Floor:      b.floor,
	}
}

func (b *VipBuilder) String() string {
	return fmt.Sprintf("* VipHouse *\n Door Type: %s\nWindow Type: %s\nFloor: %d",
		b.doorType,
		b.windowType,
		b.floor,
	)
}
