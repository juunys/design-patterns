package main

import (
	"fmt"
)

func main() {
	normalBuilder := GetNormalBuilder()
	vipBuilder := GetVipBuilder()

	director := NewDirector(normalBuilder)
	normalHouse := director.buildHouse()

	fmt.Println("** Normal House **")
	fmt.Printf("Door type: %s\n", normalHouse.doorType)
	fmt.Printf("Window type: %s\n", normalHouse.windowType)
	fmt.Printf("Floor type: %d\n", normalHouse.floor)

	fmt.Println()
	director.setBuilder(vipBuilder)
	vipHouse := director.buildHouse()

	fmt.Println("** Vip House **")
	fmt.Printf("Door type: %s\n", vipHouse.doorType)
	fmt.Printf("Window type: %s\n", vipHouse.windowType)
	fmt.Printf("Floor type: %d\n", vipHouse.floor)
}
