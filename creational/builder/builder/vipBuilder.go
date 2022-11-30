package builder

import (
	"fmt"

	m "github.com/juunys/creational/builder/model"
)

type vipBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func newVipBuilder() *vipBuilder {
	return &vipBuilder{}
}

func (b *vipBuilder) SetWindowType() {
	b.windowType = "Glass window"
}

func (b *vipBuilder) SetDoorType() {
	b.doorType = "Glass door"
}

func (b *vipBuilder) SetNumFloorType() {
	b.floor = 3
}

func (b *vipBuilder) GetHouse() m.House {
	return m.House{
		DoorType:   b.doorType,
		WindowType: b.windowType,
		Floor:      b.floor,
	}
}

func (b *vipBuilder) String() string {
	return fmt.Sprintf("* VipHouse *\n Door Type: %s\nWindow Type: %s\nFloor: %d",
		b.doorType,
		b.windowType,
		b.floor,
	)
}
