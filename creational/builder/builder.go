package main

type Builder interface {
	setWindowType()
	setDoorType()
	setNumFloorType()
	getHouse() House
}

func GetNormalBuilder() Builder {
	return newNormalBuilder()
}

func GetVipBuilder() Builder {
	return newVipBuilder()
}
