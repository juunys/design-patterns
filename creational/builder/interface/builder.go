package bInterface

import (
	c "github.com/juunys/creational/builder/concrete-builder"
	m "github.com/juunys/creational/builder/model"
)

type HouseBuilder interface {
	SetWindowType()
	SetDoorType()
	SetNumFloorType()
	GetHouse() m.House
}

func GetNormalBuilder() HouseBuilder {
	return c.NewNormalBuilder()
}

func GetVipBuilder() HouseBuilder {
	return c.NewVipBuilder()
}
