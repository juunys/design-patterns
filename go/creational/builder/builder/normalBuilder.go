package builder

import (
	"fmt"

	m "github.com/juunys/creational/builder/model"
)

type normalBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func newNormalBuilder() *normalBuilder {
	return &normalBuilder{}
}

func (b *normalBuilder) SetWindowType() {
	b.windowType = "Wooden window"
}

func (b *normalBuilder) SetDoorType() {
	b.doorType = "Wooden door"
}

func (b *normalBuilder) SetNumFloorType() {
	b.floor = 1
}

func (b *normalBuilder) GetHouse() m.House {
	return m.House{
		DoorType:   b.doorType,
		WindowType: b.windowType,
		Floor:      b.floor,
	}
}

func (b *normalBuilder) String() string {
	return fmt.Sprintf("* NormalHouse *\n Door Type: %s\nWindow Type: %s\nFloor: %d",
		b.doorType,
		b.windowType,
		b.floor,
	)
}
