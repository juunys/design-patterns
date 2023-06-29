package builder

import (
	m "github.com/juunys/creational/builder/model"
)

type HouseBuilder interface {
	SetWindowType()
	SetDoorType()
	SetNumFloorType()
	GetHouse() m.House
}

func GetNormalBuilder() HouseBuilder {
	return newNormalBuilder()
}

func GetVipBuilder() HouseBuilder {
	return newVipBuilder()
}
