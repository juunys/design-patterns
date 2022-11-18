package main

type HouseBuilder interface {
	setWindowType()
	setDoorType()
	setNumFloorType()
	getHouse() House
}

func GetNormalBuilder() HouseBuilder {
	return newNormalBuilder()
}

func GetVipBuilder() HouseBuilder {
	return newVipBuilder()
}
