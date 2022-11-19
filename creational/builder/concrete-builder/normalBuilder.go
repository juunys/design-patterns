package concreteBuilder

import (
	"fmt"

	m "github.com/juunys/creational/builder/model"
)

type NormalBuilder struct {
	windowType string
	doorType   string
	floor      int8
}

func NewNormalBuilder() *NormalBuilder {
	return &NormalBuilder{}
}

func (b *NormalBuilder) SetWindowType() {
	b.windowType = "Wooden window"
}

func (b *NormalBuilder) SetDoorType() {
	b.doorType = "Wooden door"
}

func (b *NormalBuilder) SetNumFloorType() {
	b.floor = 1
}

func (b *NormalBuilder) GetHouse() m.House {
	return m.House{
		DoorType:   b.doorType,
		WindowType: b.windowType,
		Floor:      b.floor,
	}
}

func (b *NormalBuilder) String() string {
	return fmt.Sprintf("* NormalHouse *\n Door Type: %s\nWindow Type: %s\nFloor: %d",
		b.doorType,
		b.windowType,
		b.floor,
	)
}
